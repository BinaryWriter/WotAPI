/*
 * @author: BinaryWriter
 */

namespace WotAPI.Api
{
    public class WotApi
    {
        public string app_ID;
        public string region;

        public WotApi(string app_ID, WotApiRegion region)
        {
            this.app_ID = app_ID;
            if (region == WotApiRegion.RU)
            {
                this.region = "ru";
            }
            else if (region == WotApiRegion.EU)
            {
                this.region = "eu";
            }
            else if (region == WotApiRegion.NA)
            {
                this.region = "com";
            }
            else if (region == WotApiRegion.ASIA)
            {
                this.region = "asia";
            }
        }
    }
}
