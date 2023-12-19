using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;

namespace SeleniumLab {
	public partial class Form1 : Form {

		private IWebDriver chrome;
		private IWebDriver edge;
		private IWebDriver firefox;
		private string site = String.Empty;
		private string savePath = String.Empty;
		public Form1() {
			InitializeComponent();
		}

		private void TestBtn_Click(object sender, EventArgs e) {
			site = linkBox.Text;
			if (site == String.Empty) {
				MessageBox.Show("Указана пустая ссылка.");
				return;
			}
			if (!firefoxCheckBox.Checked & !edgeCheckBox.Checked & !chromeCheckBox.Checked) {
				MessageBox.Show("Не выбран ни один браузер.");
				return;
			}
			if (savePath == String.Empty) {
				MessageBox.Show("Выберите папку для сохранения.");
				return;
			}
			int testsQuantity = 0;
			if (chromeCheckBox.Checked) {
				testsQuantity++;
			}
			if (firefoxCheckBox.Checked) {
				testsQuantity++;
			}
			if (edgeCheckBox.Checked) {
				testsQuantity++;
			}
			testsQuantity = testsQuantity * sizeLists.Items.Count;
			progBar.Maximum = testsQuantity;
			progBar.Visible = true;
			progBar.Value = 0;
			if (chromeCheckBox.Checked) {
				try {
					ChromeOptions opt = new ChromeOptions();
					ChromeDriverService service = ChromeDriverService.CreateDefaultService();
					if (isSilent.Checked) {
						opt.AddArgument("--headless");
						service.HideCommandPromptWindow = true;
					}
					chrome = new ChromeDriver(service, opt);
					chrome.Navigate().GoToUrl(site);
					for (int i = 0; i < sizeLists.Items.Count; i++) {
						string[] size = new string[2];
						size = GetWindowSize(sizeLists.Items[i].ToString());
						int width = int.Parse(size[0]);
						int height = int.Parse(size[1]);
						SetSize(chrome as WebDriver, width, height);
						Screenshot chromeShot = (chrome as ITakesScreenshot).GetScreenshot();
						chromeShot.SaveAsFile(savePath + @$"\chrome{width}x{height}.png");
						progBar.Value++;
					}
					chrome.Quit();
				}
				catch (Exception ex) {
					MessageBox.Show("Произошла ошибка", "Увы(");
					return;
				}
			}
			if (firefoxCheckBox.Checked) {
				try {
					FirefoxOptions opt = new FirefoxOptions();
					FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
					if (isSilent.Checked) {
						opt.AddArgument("--headless");
						service.HideCommandPromptWindow = true;
					}
					firefox = new FirefoxDriver(service, opt);
					firefox.Navigate().GoToUrl(site);
					for (int i = 0; i < sizeLists.Items.Count; i++) {
						string[] size = new string[2];
						size = GetWindowSize(sizeLists.Items[i].ToString());
						int width = int.Parse(size[0]);
						int height = int.Parse(size[1]);
						SetSize(firefox as WebDriver, width, height);
						Screenshot firefoxShot = (firefox as ITakesScreenshot).GetScreenshot();
						firefoxShot.SaveAsFile(savePath + @$"\firefox{width}x{height}.png");
						progBar.Value++;
					}
					firefox.Quit();
				}
				catch (Exception ex) {
					MessageBox.Show("Произошла ошибка", "Увы(");
					return;
				}
			}
			if (edgeCheckBox.Checked) {
				try {
					EdgeOptions opt = new EdgeOptions();
					EdgeDriverService service = EdgeDriverService.CreateDefaultService();
					if (isSilent.Checked) {
						opt.AddArgument("--headless");
						service.HideCommandPromptWindow = true;
					}
					edge = new EdgeDriver(service, opt);
					edge.Navigate().GoToUrl(site);
					for (int i = 0; i < sizeLists.Items.Count; i++) {
						string[] size = new string[2];
						size = GetWindowSize(sizeLists.Items[i].ToString());
						int width = int.Parse(size[0]);
						int height = int.Parse(size[1]);
						SetSize(edge as WebDriver, width, height);
						Screenshot ieShot = (edge as ITakesScreenshot).GetScreenshot();
						ieShot.SaveAsFile(savePath + @$"\edge{width}x{height}.png");
						progBar.Value++;
					}
					edge.Quit();
				}
				catch (Exception ex) {
					MessageBox.Show("Произошла ошибка", "Увы(");
					return;
				}
			}
			progBar.Visible = false;
			MessageBox.Show("Тестирование завершено.");
		}

		string[] GetWindowSize(string size) {
			return size.Split(" x ");
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
			if (chrome != null) {
				chrome.Quit();
			}
			if (firefox != null) {
				firefox.Quit();
			}
			if (edge != null) {
				edge.Quit();
			}
		}

		private void button1_Click(object sender, EventArgs e) {
			DialogResult result = folderBrowserDialog1.ShowDialog();
			if (result == DialogResult.OK) {
				savePath = folderBrowserDialog1.SelectedPath;
				folderLabel.Text = savePath.Split('\\')[0] + @"\...\" + savePath.Split('\\')[savePath.Split('\\').Count() - 1];
				var test = savePath.Split('\\');
			}
		}

		private void Form1_Load(object sender, EventArgs e) {
			sizeLists.SelectedIndex = 0;
			linkBox.Text = @"https://worldlab.technolog.edu.ru/";
			progBar.Minimum = 0;
			progBar.Visible = false;
		}

		private void SetSize(WebDriver driver, int width, int height) {
			string jsGetPadding = @"return [ window.outerWidth - window.innerWidth,window.outerHeight - window.innerHeight ];";
			var paddings = driver.ExecuteScript(jsGetPadding) as ReadOnlyCollection<object>;
			driver.Manage().Window.Size = new Size(width + int.Parse(paddings[0].ToString()), height + int.Parse(paddings[1].ToString()));
		}

		private void AddSize_Click(object sender, EventArgs e) {
			Regex filter = new Regex(@"^[0-9]+ x [0-9]+$");
			var matches = filter.Matches(newSize.Text);
			if (matches.Count > 0) {
				foreach (Match match in matches) {
					sizeLists.Items.Add(match.Value);
				}
				newSize.Text = String.Empty;
			} else {
				MessageBox.Show(@"Размер должен быть в формате ""число x число""");
			}
		}
	}
}