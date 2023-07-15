using Project_Ti_Infinite.Objects.Campaigns;
using Project_Ti_Infinite.Singletons;

namespace Project_Ti_Infinite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Terminal.Instance.Initialise();
            mainMenu();
            Console.ReadLine();
        }

        private static void mainMenu()
        {
            List<string> story = new List<string>() { "Welcome to Ti Infinite!" };
            List<string> options = new List<string>() { "Campaign Selector", "Campaign Creator" };
            Terminal.Instance.UpdateStory(story);
            Terminal.Instance.UpdateOptions(options);
            int input = Terminal.Instance.Input(options.Count);
            switch (input)
            {
                case 1:
                    campaignSelector();
                    break;
                case 2:
                    story = new List<string>() { "The Campaign Creator is not currently avaiable. It will be added in a later version of the game" };
                    options = new List<string>() { "Continue" };
                    Terminal.Instance.UpdateStory(story);
                    Terminal.Instance.UpdateOptions(options);
                    Terminal.Instance.Input(options.Count);
                    mainMenu();
                    break;
                default: 
                    break;
            }
        }

        private static void campaignSelector()
        {
            List<string> campaigns = getCampaignFiles();
            Terminal.Instance.UpdateStory(campaigns);
            campaigns.RemoveAt(0);
            campaigns.RemoveAt(0);
            int input = Terminal.Instance.SelectItem(campaigns);
            if(input == -1)
            {
                mainMenu();
            }
            else
            {
                Campaign campaign = new Campaign_Loader().LoadCampaign();
                gameLoop(campaign);
            }
        }

        private static void gameLoop(Campaign campaign)
        {

        }

        private static List<string> getCampaignFiles()
        {
            List<string> story = new List<string>() { "Campaigns", "" };
            string[] campaignFiles = Directory.GetFiles("Campaigns\\", "*.xml");
            for(int x = 0; x < campaignFiles.Length; x++)
            {
                campaignFiles[x] = campaignFiles[x].Substring(10);
                int stringLength = campaignFiles[x].Length - 4;
                campaignFiles[x] = campaignFiles[x].Remove(stringLength);
                story.Add(campaignFiles[x]);
            }
            return story;
        }
    }
}