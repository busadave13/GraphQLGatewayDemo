using Newtonsoft.Json;

namespace Entitlements.Service
{
    public class EntitlementService : IEntitlementService
    {
        private IList<Entitlement> _entitlements;

        public EntitlementService()
        {
            using (StreamReader r = new StreamReader("entitlements.json"))
            {
                string json = r.ReadToEnd();
                _entitlements = JsonConvert.DeserializeObject<List<Entitlement>>(json);
            }
        }

        public async Task<IList<Entitlement>> GetAllEntitlementsAsync()
        {
            return await Task.FromResult(_entitlements);
        }
    }
}
