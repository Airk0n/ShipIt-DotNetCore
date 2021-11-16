namespace ShipIt.Models.ApiModels
{
    public class OutboundOrderRequestResponse
    {
        public OutboundOrderRequestResponse(double totalWeightKg, double truckRequired)
        {
            TotalWeightKG = totalWeightKg;
            TrucksRequired = truckRequired;
        }

        public double TotalWeightKG { get; set; }
        public double TrucksRequired { get; set;}
    }
}