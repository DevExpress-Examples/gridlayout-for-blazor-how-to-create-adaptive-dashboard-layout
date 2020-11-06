using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace DxLayoutGridAdaptivity.Data {
    public class SaleInfoService {
        SaleInfo[] saleInfo;
        SaleInfo[] SaleInfo => saleInfo ?? (saleInfo = JsonSerializer.Deserialize<SaleInfo[]>(File.ReadAllText("wwwroot/sample-data/salesdata.json")));
        public IEnumerable<SaleInfo> GetSaleInfos() {
            return SaleInfo;
        }
    }
}
