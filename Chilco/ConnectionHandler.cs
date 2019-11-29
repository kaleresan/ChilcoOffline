using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using WebSocketSharp;
using static Chilco.Group;

namespace Chilco
{
    internal static class ConnectionHandler
    {
        private const string DOMAIN = "http://chilco.de";
        private static string authToken;

        public static void Connect()
        {
            authToken = FileIO.LoadAuthToken();
            if (authToken.IsNullOrEmpty())
            {
                RegisterHandshake();
            }

            UpdateRuleset();
            ConnectWebsocket();
        }

        private static void RegisterHandshake()
        {
            using (var ws = new WebSocket(DOMAIN))
            {
                ws.OnMessage +=
                (sender, e) =>
                {
                    //TODO Implement Register Handshake
                    //save auth token with FileIO
                };

                ws.Connect();
            }
        }

        internal static void OpenWebsite(string token)
        {
            System.Diagnostics.Process.Start(DOMAIN + "/register/" + token);
        }

        private static void ConnectWebsocket()
        {
            using (var ws = new WebSocket(DOMAIN))
            {
                ws.OnMessage +=
                (sender, e) =>
                {
                    UpdateRuleset();
                };

                ws.Connect();
            }
        }

        private static void UpdateRuleset()
        {
            //TODO Implement API GET request
            //throw new NotImplementedException();

            //this is just an example on how it could be with some example data

            var client = new RestClient(DOMAIN);

            string username = "";

            var request = new RestRequest("settings/" + username, Method.GET);

            request.AddHeader("x-access-token", authToken);

            // execute the request
            IRestResponse response = client.Execute(request);
            List<Ruleset> RulesetList = new List<Ruleset>();

            if (response.IsSuccessful)
            {
                var content = response.Content; // raw content as string

                Ruleset[] rulesets = Newtonsoft.Json.JsonConvert.DeserializeObject<Ruleset[]>(content);
                RulesetList.AddRange(rulesets);
            }
            else
            {
                Group[] groups = FileIO.LoadGroups();
                if (groups == null || groups.Length == 0)
                {
                    RulesetList.AddRange(GetDefaultRulesets());
                }
                else
                {
                    RulesetList.AddRange(groups.Select(group => group.ruleset).ToList());
                }
            }

            Main.Update(RulesetList.ToArray());
        }

        private static Ruleset[] GetDefaultRulesets()
        {
            IList<Ruleset> RulesetList = new List<Ruleset>() {
                    new Ruleset() {
                        Key = "Default1",
                        Title = "Browser",
                        Processes = new List<string>()
                                    {
                                        "Firefox",
                                        "Chrome"
                                    },
                        DoTimeRollover = true,
                        DailyPlaytime = new TimeSpan(0, 0, 30, 0, 0)
                    } ,

                    new Ruleset() {
                        Key = "Default2",
                        Title = "Games",
                        Processes = new List<string>()
                                    {
                                        "Nidhogg",
                                        "Stardew Valley",
                                        "Unturned",
                                        "Ace of Spades",
                                        "Counterstrike Global Offensive"
                                    },
                        DoTimeRollover = true,
                        DailyPlaytime = new TimeSpan(0, 2, 0, 0, 0)
                    } ,

                    new Ruleset() {
                        Key = "Default3",
                        Title = "Malicious Utilities",
                        Processes = new List<string>()
                                    {
                                        "cmd",
                                        "PowerShell"
                                    },
                        DoTimeRollover = true,
                        DailyPlaytime = new TimeSpan(0, 0, 0, 0, 0)
                    } ,

                    new Ruleset() {
                        Key = "Default4",
                        Title = "",
                        Processes = new List<string>()
                                    {
                                        "",
                                        ""
                                    },
                        DoTimeRollover = true,
                        DailyPlaytime = new TimeSpan(0, 0, 0, 0, 0)
                    } ,
                };

            return RulesetList.ToArray();
        }
    }
}