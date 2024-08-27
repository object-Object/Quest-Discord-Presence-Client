namespace Quest_Discord_Presence_Client
{

    // Used to pass info from the presence manager to the UI
    public class ClientStatus
    {
        public string Info { get; }

        private ClientStatus(string info)
        {
            this.Info = info;
        }

        public static readonly ClientStatus RequestFailed = new ClientStatus("The client could not reach your quest.\nMake sure that beat saber is open, your headset on\nand your IP address correct");

        public static readonly ClientStatus RequestSucceeded = new ClientStatus("Successfully received presence from Quest!");

        public static readonly ClientStatus RequestSucceededButIdle = new ClientStatus("Successfully received presence from Quest,\nbut disabled Discord presence due to idle timeout");

        public static readonly ClientStatus NoRequestMade = new ClientStatus("No request to your quest has been made yet");
    }
}
