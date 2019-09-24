using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using System.Security.Cryptography;

namespace testing_purpose
{
	class MainClass
	{
		static bool status=true;
		static string ans;
		public static void Main (string[] args)
		{
			//================================= Replace list
			List<int> First = new List<int>{ 2, 3, 4, 5 };
//			First.Add(2);
//			First.Add(3);
//			First.Add(4);
//			First.Add(5);

//			foreach (int i in First) {
//				Console.WriteLine (i.ToString ());
//			}
//
//			Console.WriteLine ("After Insert");
//
//			First.Insert (0, 13);
//
//			foreach (int i in First) {
//				Console.WriteLine (i.ToString ());
//			}

			//================================= Calculation hex

//			string BankNoInHex = (1*0x100).ToString();
//
//			Console.WriteLine("BankNoInHex:"+BankNoInHex);
//
//			BankNoInHex = (2*0x100).ToString("X2");
//
//			Console.WriteLine("BankNoInHex:"+BankNoInHex);
//
//			BankNoInHex = (3*0x100).ToString("X4");
//
//			Console.WriteLine("BankNoInHex:"+BankNoInHex);

//			string i = "30";
//
//			int j = Int32.Parse (i, System.Globalization.NumberStyles.HexNumber);
//
//			Console.WriteLine (j.ToString ());

//			int hex_a = 0x0060;
//
//			int add_hex = 0x0010;
//
//			Console.WriteLine ((hex_a + add_hex).ToString ("X4"));

			//================================= Calculation hex

			//================================= Check list



			//================================= Check list
//			List<int> Second = new List<int>();
////			Second.Any ();
////			int? rec = Second.First ();
//
//			if (!Second.Any ()) {
//				Console.WriteLine ("Null");
//			} else {
//				Console.WriteLine ("Has Value");
//			}
			//=================================

			//================================= Check stringbuilder
//			string listbefore = "AirconTimer , DataLog , DeviceLog , Gateway , Holiday , Image , IRDevice, IRDeviceCode , IRTransmitter , IRTransmitterSlot , RCU  , RCUButton , TBLDiagnostic , TBLDiagnosticLog , TBLDiaognosticHistory , WirelessOutput";
//			string[] listafter = listbefore.Split (',');
//			StringBuilder testa = new StringBuilder();
////			int o = 1;
////			string asd= " asdsadsad";
////			testa.Append (o);
////			testa.Append ("asd_we");
////			for(int i =0;i<=10;i++){
////				Console.WriteLine ("DROP_COLUMN_IF_EXIST(\'SWITCH\',\'FAV" + i.ToString()+ "\');");
////			}
//			foreach (string la in listafter) {
////				Console.WriteLine("DROP_COLUMN_IF_EXIST(\'POCKETREMOTE\',\'"+la.Trim().ToUpper()+"\');");
//				Console.WriteLine("DROP_TABLE_IF_EXIST(\'"+la.Trim().ToUpper()+"\');");
//			}
//			Console.WriteLine (testa.ToString().ToUpper());
			//================================= 


			//Console.WriteLine (Second.First ().ToString ());
//
//			Second.Add(3);
//			Second.Add(2);
//
//
//			List<int> Third ;
//			Third = First.Except(Second).ToList();
//			Console.WriteLine ("InList:");
//			foreach (int inList in Third) {
//				Console.WriteLine (inList.ToString());
//			}
//			Console.WriteLine ("First Element:" + Third.First ());
//
//
//			string word1 = "11223344";
//			Console.WriteLine(word1.Substring(0,2));
//			Console.WriteLine(word1.Substring(2,2));
//			Console.WriteLine(word1.Substring(4,2));
//			string qwe="{asdasd \n" +
//				"zxczxc \n" +
//				"asdasd} \n";
//			//ParseReadBuffer2 (qwe);
//			Regex regex = new Regex(@"\{([^)]*)\}");
//			Match match = regex.Match(qwe);
//			if (match.Success) {
//				Console.WriteLine ("MATCH VALUE: " + match.Value);
//			} else {
//				Console.WriteLine ("UNMATCH VALUE: " + match.Value);
//			}
//			string word1 = "11223344";
//			Console.WriteLine(word1.Substring(0,2));
//			Console.WriteLine(word1.Substring(2,2));
//			Console.WriteLine(word1.Substring(4,2));
//			Console.WriteLine(word1.Substring(6,2));
//			for(int i=1;i<=100;i++){
//				Console.Write (i + ",");
//			}

			//=================================Test enum
//			var valuesAsList = Enum.GetValues(typeof(IRTVButton)).Cast<IRTVButton>().ToList();
//
//			foreach(IRTVButton item in valuesAsList){
//				Console.WriteLine (Convert.ToInt32(item));
//			}
//
//			Console.WriteLine ();
//
//			foreach(IRTVButton item in Enum.GetValues(typeof(IRTVButton))){
//				Console.WriteLine (Convert.ToInt32(item));
//			}
		
			//=================================

			//=================================TestThread
//			testModel m = new testModel();
//
////			ThreadStart test = new ThreadStart (testThread);
//			Thread startTest = new Thread (m.testThread);
//			startTest.IsBackground = true;
//			startTest.Start ();
//
//			string s = Console.ReadLine ();
//			while (!string.Equals (s, "q")) {
//				Console.WriteLine ("B");
//			}
//
//			m.status = false;

			//=================================


			//=================================TestCompress
//			string text = File.ReadAllText("C:\\Users\\aiman\\Desktop\\FireBird Database\\FirsttimeswitchlistLog.txt"); 
//			string text2 = Compress (text);
//			Console.WriteLine ("Switch Before:" + text.Length + " After Compress:" + text2.Length);
//
//			text = File.ReadAllText("C:\\Users\\aiman\\Desktop\\FireBird Database\\SensorDeviceListLog4.txt"); 
//			text2 = Compress (text);
//			Console.WriteLine ("Sensor Before:" + text.Length + " After Compress:" + text2.Length);
//
//			text = File.ReadAllText("C:\\Users\\aiman\\Desktop\\FireBird Database\\Log.txt"); 
//			text2 = Compress (text);
//			Console.WriteLine ("Log Before:" + text.Length + " After Compress:" + text2.Length);

			//=================================TestCompress

			//=================================TestCompress //https://point2blog.wordpress.com/2012/12/26/compressdecompress-a-string-in-c/

//			JObject test = new JObject ();
//
//			var smartSwitchArray = new JArray ();
//
//			test.Add ("SmartSwitch", smartSwitchArray);
//
//			string message = test.ToString(Newtonsoft.Json.Formatting.None) + "\n";
//
//			string output = test.ToString (Newtonsoft.Json.Formatting.Indented);
//
//			Console.WriteLine (message);
//
//			Console.WriteLine (output);


			//=================================TestCompress


			//=================================TestCancelToken //https://binary-studio.com/2015/10/23/task-cancellation-in-c-and-things-you-should-know-about-it/

//			CancellationTokenSource tokenSource = new CancellationTokenSource();
//			CancellationToken token = tokenSource.Token;
//			tokenSource.CancelAfter (5000);
////			tokenSource.Cancel ();
//			int i = 0;
//			var asd = Task.Run(() => {
////				while(!token.IsCancellationRequested){
////				while(true){
////					Console.WriteLine("Practice");
//				return testtoken(token);
////					Thread.Sleep(1000);
////					i++;
////					if(i == 5){
////						tokenSource.Cancel();
////					}
////				}
//			}, token);
//			asd.Wait(5000);
//			tokenSource.Cancel ();
//			Console.WriteLine ("asd");
//			Console.WriteLine (asd.Result);
			//=================================TestCancelToken


			//=================================TestTimer

			//=================================TestTimer

			//=================================Tesgetproperty
//			JObject jsonReply = new JObject(
//				new JProperty("Command", "testName")
//			);
//
//			JObject json2 = new JObject(
//				new JProperty("Command", "testName")
//			);
//
//			JArray jsonArray = new JArray ();
//
//			json2.Add ("Array", jsonArray);
//
//			JObject json3 = new JObject(
//				new JProperty("Command", "Login")
//			);
//
//			jsonReply.Add ("Reply", true);
//			jsonReply.Add("SmartAlarm", "123");
//			jsonReply.Add("JSON2", json2);
//			jsonReply.Add("JSON3", json3);
//
//			string output = jsonReply.ToString (Newtonsoft.Json.Formatting.Indented);
//			Console.WriteLine (output);
//
//			Console.WriteLine(jsonReply.Property ("Command").Value);

			//Console.WriteLine(jsonReply.);

			//=================================Testgeproperty

			//=================================TestCheck \r\n

//			string listbefore = "qweasd$nasdqwe";
//			if (listbefore.Contains ("$"))
//			{
//				Console.WriteLine("$ exist");
//			}
//			Console.WriteLine (listbefore);


			//=================================Test		Check \r\n

			//=================================TestCheck \r\n


//			WebClient client = new WebClient ();
//			string reply = client.DownloadString ("http://senzo.com.my/downloads/SenzoServerInfo/SenzoInfo.txt");
//
//			var http = (HttpWebRequest)WebRequest.Create("http://senzo.com.my/downloads/SenzoServerInfo/SenzoInfo.txt");
//			var response = http.GetResponse();
//
//			var stream = response.GetResponseStream();
//			var sr = new StreamReader(stream);
//			var content = sr.ReadToEnd();
//
//			Console.WriteLine (content);

			//=================================Test		Check \r\n


			//=================================Search Last Occurrence \r\n


//			string topicArgument = "Senzo/Server/Client/UpdateLightIntensity";
//
//			int startIndex = topicArgument.LastIndexOf ('/');
//
//			if (startIndex != -1) {
//				Console.WriteLine(topicArgument.Substring(startIndex+1));
//			}

			//string re = IRTVButton.CH1.ToString();

			//Console.WriteLine (re);

			//=================================Test		Check \r\n

			//=================================modify string \r\n


//			string topicArgument = "{switchNo:2, Firelevel:0}";
//			
//			int startIndex = topicArgument.LastIndexOf ('}');
//
//			if (startIndex != -1) {
//				string modified = topicArgument.Insert (startIndex, ", UserWaitForAck:False");
//				Console.WriteLine(modified);
//			}



			//=================================modify string \r\n


			//=================================Tesgetproperty
//			string loginStr = "{User:'testupdate3', Password:'qqqqqqqq'}";
//
//			int startIndex2 = loginStr.LastIndexOf ('}');
//
//			if (startIndex2 != -1) {
//				Console.WriteLine(loginStr.Substring(startIndex2+1));
//			}
//
//			loginStr = loginStr.Insert (startIndex2, " , RPCTopic:'asdas'");
//
//			JObject loginJson = JObject.Parse (loginStr);
//
//			Console.WriteLine (loginJson.ToString ());

			//Console.WriteLine(jsonReply.);

			//=================================Testgeproperty


			//=================================Downlaod String

//			string contents = string.Empty;
////			using (var wc = new System.Net.WebClient())
////				contents = wc.DownloadString("http://localhost/MQTT_Domain/domain_list.txt");
////			using (var reader = File.ReadAllText("C:\\xampp\\htdocs\\MQTT_Domain\\domain_list.txt"))
////			{
////				var fileText = await reader.ReadToEndAsync();
////				// Do something with fileText...
////			}
//			if(File.Exists("domain_list.txt")){
//
//				contents = File.ReadAllText ("domain_list.txt");
//
//			}
//
//			Console.WriteLine (contents);
//			//JObject domainObject = JObject.Parse (contents);
//			JArray domainArray = JArray.Parse (contents);
//			List<DomainObject> asd = JsonConvert.DeserializeObject<List<DomainObject>> (contents);
//			//Console.WriteLine (domainArray [0] ["Domain"]);
//
//			foreach (var domain in asd) {
//				Console.WriteLine (domain.domain);
//				Console.WriteLine (domain.url);
//				Console.WriteLine (domain.port);
//				Console.WriteLine ();
//			}
//
//			DomainObject searchDomain = asd.Find (i => string.Equals (i.domain, "central.com.my"));
//
//			if (asd != null) {
//				Console.WriteLine ("Assigned url:"+searchDomain.url);
//				Console.WriteLine ("Assigned port:"+searchDomain.port);
//			}
//
			//=================================Download String


			//=================================md5 hashing

//			string hash = CalculateMD5Hash("123456");
//
//			Console.WriteLine ("Hash string:" + hash);

			//=================================md5 hashing

			//=================================Extract DateTime

			DateTime StartTime = new DateTime (2019, 9, 9, 8, 5, 4);

			Console.WriteLine(string.Format("Hour:{0} \nMinute:{1}",StartTime.Hour.ToString(),StartTime.Minute.ToString()));

			//=================================Extract DateTime


			Console.ReadLine ();

		}


		public static string CalculateMD5Hash(string input)
		{
			// step 1, calculate MD5 hash from input
			MD5 md5 = System.Security.Cryptography.MD5.Create();
			byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
			byte[] hash = md5.ComputeHash(inputBytes);

			// step 2, convert byte array to hex string
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < hash.Length; i++)
			{
				sb.Append(hash[i].ToString("x2"));
			}
			return sb.ToString();
		}

		public static bool testtoken(CancellationToken token){
			int i = 0;
			while(true){
				if(token.IsCancellationRequested){
					return false;
				}
				Console.WriteLine ("Practice 2");
				Thread.Sleep (1000);
//				i++;
			}
			return true;
		}

		public static string Compress(string s)
		{
			var bytes = Encoding.Unicode.GetBytes(s);
			using (var msi = new MemoryStream(bytes))
			using (var mso = new MemoryStream())
			{
				using (var gs = new GZipStream(mso, CompressionMode.Compress))
				{
					msi.CopyTo(gs);
				}
				return Convert.ToBase64String(mso.ToArray());
			}
		}

		public static void testThread (testModel x){
			while (x.status) {
				Console.WriteLine ("O");
				Thread.Sleep (1000);
			}

			Console.WriteLine ("Thread Stopped");
		}

		public enum IRTVButton {
			Unknown = 0,
			CH1 = 1,
			CH2 = 2,
			CH3 = 3,
			CH4 = 4,
			CH5 = 5,
			CH6 = 6,
			CH7 = 7,
			CH8 = 8,
			CH9 = 9,
			CH10 = 10,
			POWER = 16,
			CHUP = 17,
			CHDWN = 18,
			VOLUMEUP = 19,
			VOLUMEDWN = 20,
			MUTE = 21,
			REPBCKSWAP = 22,
			OK = 23,
			UP = 24,
			DWN = 25,
			LEFT = 26,
			RIGHT = 27,
			SCREEN = 32,
			TVAV = 33,
			MENU = 34,
			MULT = 35
		}

		public static bool True (){
			return true;
		}

		public static bool False (){
			return false;
		}

		private void ParseReadBuffer2(string fullline)
		{
			bool cont = true;
			fullline = fullline.Trim();
			string[] _listOfCommands = fullline.Split('\n');
			foreach (string line in _listOfCommands) {
				while (cont) {
				}
			}
		}

		private void ParseReadBuffer(string fullline)
		{
			Console.WriteLine("Parse 1"); // testParse
			JObject jObject = null;
			//setup debug message here
			//Debug.WriteLine ( "<{0}> Command: {1}", typeof(SCommandManager), text );

			fullline = fullline.Trim();
			string[] _listOfCommands = fullline.Split('\n');
			foreach (string line in _listOfCommands)
			{
				var indexOfOpenCurlyBracket = line.IndexOf("{", StringComparison.Ordinal);
				string header;
				if (indexOfOpenCurlyBracket > 0)
				{
					header = line.Substring(0, indexOfOpenCurlyBracket).Trim();
				}
				else
				{
					//header = string.Empty; //line.Trim (); commented out cause some commands is does come with curly braces
					header = line.Trim();
				}

				Console.WriteLine("Header:" + header+"**");

				string parameter;
				if (indexOfOpenCurlyBracket > 0)
				{
					parameter = line.Substring(indexOfOpenCurlyBracket);
				}
				else
				{
					parameter = string.Empty;
				}

				Console.WriteLine("Parameter:" + parameter);

				if (string.IsNullOrEmpty(parameter))
				{
					try
					{
						jObject = JObject.Parse(line);
					}
					catch (Exception ex)
					{
						//ShowDebug here
						Console.WriteLine(string.Format("JObject Parse Exception: {0}", ex.Message));
					}
				}
				else
				{
					try
					{
						jObject = JObject.Parse(parameter);
					}
					catch (Exception ex)
					{
						//ShowDebug here
						Console.WriteLine(string.Format("JObject Parse Exception: {0}", ex.Message));
					}
				}
				if (jObject == null)
				{
					//handle error
					Console.WriteLine(string.Format("JObject is null"));
					//return;
				}
				try
				{
					var jobjectText = jObject.ToString();
					string text = (jobjectText.Length < 200) ? jobjectText : (jobjectText.Substring(0, 200) + "...");
					Console.WriteLine("From server:" + text + "**");

					//TODO: #DEBUG
					//                if ( SGlobal.IsDebugMode && SGlobal.ShowToastDebug ) {
					//                    Xamarin.Forms.Device.BeginInvokeOnMainThread(async () =>
					//                    {
					//                        await NLibraryForms.NToastNotificator.NotifyAsync(Plugin.Toasts.ToastNotificationType.Custom, "From Server: " + header, text, TimeSpan.FromMilliseconds ( 500 ), NLibraryForms.EToastCustom.Received);
					//                    });   
					//                }
				}
				catch (Exception ex)
				{
					string text = (line.Length < 200) ? line : (line.Substring(0, 200) + "...");
					Console.WriteLine("From server:" + text +"**");
				}
				ProcessReceivedCommand(line, header, parameter);
			}
		}

		private void ProcessReceivedCommand(string line, string header, string parameter)
		{
			Console.WriteLine("Parse 3");
			// testParse
			//string header;
			//string text = (line.Length < 200) ? line : (line.Substring(0, 200) + "...");
			////      Global.DebugWriteLineWithTime("From server: " + text);
			//Global.DebugWriteLineWithTime("Received: " + text, ConsoleColor.DarkYellow, ConsoleColor.Black);
			//int indexOfOpenCurlyBracket = line.IndexOf("{", System.StringComparison.Ordinal);
		}
	}

	class testModel{

		public bool status = false;

		public testModel(){
			status = true;
		}

		public void testThread (){
			while(status){
				Console.WriteLine("testModel");
				Thread.Sleep(1000);
			}
		}

	}

	public class DomainObject{

		public string domain { get; set; }
		public string url { get; set; }
		public int port { get; set; }

	}


}
