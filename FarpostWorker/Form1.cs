using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FarpostWorker
{
    public partial class Autorization_form : Form
    {
        public IWebDriver driver = new ChromeDriver();

        public Autorization_form()
        {
            InitializeComponent();
        }

        private async void entrBtn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Проверка правильности имени пользователя и пароля (примерная проверка)
            if (username == "AvtoEnergiya" && password == "6dQrK7Erq!FNb4Q")
            {
                MessageBox.Show("Добро пожаловать, " + username + "!", "Вход выполнен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                smsGetter run = new smsGetter();
                run.Show();

                try
                {
                    await LoginInFarpost.Login(driver, username, password);
                    AllPrices all = new AllPrices();
                    all.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка при выполнении входа: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class LoginInFarpost
        {
            public static async Task Login(IWebDriver driver, string username, string pass)
            {
                // Грузим куки
                string path = Directory.GetCurrentDirectory() + @"\ProfCookie\Cookies.txt";

                await Task.Run(() => driver.Navigate().GoToUrl("https://www.farpost.ru/"));
                await Task.Delay(2000);

                try
                {
                    await Task.Run(() => LoadCookiesFromFile(driver, path));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Не удалось загрузить куки");
                }

                var loginClk = driver.FindElements(By.XPath("//a[contains(@href,'sign')]"));
                if (loginClk.Count > 0)
                {
                    var login = loginClk.FirstOrDefault();
                    await Task.Run(() => login.Click());
                    await Task.Delay(2000);

                    List<IWebElement> sign = driver.FindElements(By.XPath("//input[contains(@name,'sign')]")).ToList();
                    if(sign.Count > 0)
                    {
                        IWebElement sg = sign.FirstOrDefault();
                        await Task.Run(() => sg.Click());
                        await Task.Run(() => sg.SendKeys(username));
                        await Task.Delay(2000);
                    }

                    List<IWebElement> passField = driver.FindElements(By.XPath("//input[contains(@name,'password')]")).ToList();
                    if(passField.Count > 0)
                    {
                        IWebElement pasF = passField.FirstOrDefault();
                        await Task.Run(() => pasF.Click());
                        await Task.Run(() => pasF.SendKeys(pass));
                        await Task.Delay(2000);
                    }

                    List<IWebElement> loginBtn = driver.FindElements(By.XPath("//button[contains(@id,'signbutton')]")).ToList();
                    if(loginBtn.Count > 0)
                    {
                        IWebElement lb = loginBtn.FirstOrDefault();
                        await Task.Run(() => lb.Click());
                        await Task.Delay(2000);
                    }

                    // Клик на отправить код в смс
                    var sendBtn = driver.FindElements(By.XPath("//a[contains(text(),'Отправить код в СМС')]"));
                    if (sendBtn.Count > 0)
                    {
                        var snd = sendBtn.FirstOrDefault();
                        await Task.Run(() => snd.Click());
                        await Task.Delay(2000);
                    }
                    await Task.Delay(2000);

                    List<IWebElement> getSms = driver.FindElements(By.XPath("//button[contains(@type, 'submit')]")).ToList();
                    if(getSms.Count > 0)
                    {
                        IWebElement sms = getSms.FirstOrDefault();
                        await Task.Run(() => sms.Click());
                        await Task.Delay(2000);
                    }

                    // Записываем куки для входа
                    string path2 = Directory.GetCurrentDirectory() + @"\ProfCookie\Cookies.txt";

                    var cookies = driver.Manage().Cookies.AllCookies;
                    await Task.Run(() => SaveCookiesToFile(cookies, path2));

                    Console.WriteLine("Путь до профиля: " + path2);
                    Console.WriteLine("Куки записаны");
                }
            }

            private static void LoadCookiesFromFile(IWebDriver driver, string filePath)
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("Файл с куками не найден.");
                    return;
                }

                // Прочитайте куки из файла
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(';');
                    if (parts.Length == 5)
                    {
                        string name = parts[0].Trim();
                        string value = parts[1].Trim();
                        string domain = parts[2].Trim();
                        string path = parts[3].Trim();

                        DateTime expiry;
                        if (DateTime.TryParseExact(parts[4].Trim(), "dd.MM.yyyy HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out expiry))
                        {
                            // Создайте объект Cookie
                            OpenQA.Selenium.Cookie cookie = new OpenQA.Selenium.Cookie(name, value, domain, path, expiry);

                            // Добавьте куку в драйвер
                            driver.Manage().Cookies.AddCookie(cookie);
                        }
                        else
                        {
                            Console.WriteLine($"Ошибка при парсинге даты и времени: {parts[4].Trim()}");
                            // Здесь можно добавить обработку ошибки или просто пропустить эту куку
                        }
                    }
                }

                Console.WriteLine("Куки успешно загружены.");
            }

            private static void SaveCookiesToFile(IEnumerable<OpenQA.Selenium.Cookie> cookies, string filePath)
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (var cookie in cookies)
                    {
                        sw.WriteLine($"{cookie.Name};{cookie.Value};{cookie.Domain};{cookie.Path};{cookie.Expiry}");
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}
