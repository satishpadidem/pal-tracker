namespace PalTracker
{
    public class CloudFoundryInfo
    {
        public CloudFoundryInfo(string pORT, string mEMORY_LIMIT, string cF_INSTANCE_INDEX, string cF_INSTANCE_ADDR)
        {
            Port  = pORT;
            MemoryLimit  = mEMORY_LIMIT;
            CfInstanceIndex  = cF_INSTANCE_INDEX;
            CfInstanceAddr  = cF_INSTANCE_ADDR;
        }

        public string Port {get;}
        public string MemoryLimit  {get;}
        public string CfInstanceIndex  {get;}
        public string CfInstanceAddr  {get;}
    }
}
