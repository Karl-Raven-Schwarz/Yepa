
using Com.OneSignal.Abstractions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Yepa.Models;

namespace Yepa.Services {
    public class OneSignalService {

        public OneSignalService() { }

        const string UriOneSignal = "https://onesignal.com/api/v1/notifications";


        public void SendNotification(NotificationModel.Root _notificationmodel) {
            var request = WebRequest.Create(UriOneSignal) as HttpWebRequest;
            request.KeepAlive = true;
            request.Method = "POST";
            request.ContentType = "application/json; charset=utf-8";
            request.Headers.Add("authorization", "Basic ZjAyOGQ4NTQtODgxYy00MDBkLWI1M2ItNTZkYTI0YTkxZTQ2");

            var param = JsonConvert.SerializeObject(_notificationmodel);
            byte[] byteArray = Encoding.UTF8.GetBytes(param);
            //string responseContent = null;

            try {
                using (var writer = request.GetRequestStream()) {
                    writer.Write(byteArray, 0, byteArray.Length);
                } using (var response = request.GetResponse() as HttpWebResponse) {
                    using (var reader = new StreamReader(response.GetResponseStream())) {
                        //responseContent = reader.ReadToEnd();
                    }
                }
            } catch (WebException ex) {
                Console.WriteLine(ex.Message);
            }
            //System.Diagnostics.Debug.WriteLine(responseContent);
        }

        public static void OneSignalSetExternalUserId(Dictionary <string, object> results) {
            // The results will contain push and email success statuses
            Console.WriteLine("External user id updated with results: " + Json.Serialize(results));
            // Push can be expected in almost every situation with a success status, but
            // as a pre-caution its good to verify it exists
            if (results.ContainsKey("push")) {
                Dictionary<string, object> pushStatusDict = results["push"] as Dictionary<string, object>;
                if (pushStatusDict.ContainsKey("success")) {
                    Console.WriteLine("External user id updated for push with results: " + pushStatusDict["success"] as string);
                }
            }
            // Verify the email is set or check that the results have an email success status
            if (results.ContainsKey("email")) {
                Dictionary<string, object> emailStatusDict = results["email"] as Dictionary<string, object>;
                if (emailStatusDict.ContainsKey("success")) {
                    Console.WriteLine("External user id updated for email with results: " + emailStatusDict["success"] as string);
                }
            }
        }
    }
}
