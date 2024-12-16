namespace WebApi.Models
{
public class Location
{
    public int Id { get; set; } // Primary Key
    public string? WhId { get; set; }
    public string? LocationId { get; set; }
    public string? Description { get; set; }
    public string? ShortLocationId { get; set; }
    public string? Status { get; set; }
    public string? Zone { get; set; }
    public double? PickingFlow { get; set; }
    public string? CapacityUom { get; set; }
    public int? CapacityQty { get; set; }
    public int? StoredQty { get; set; }
    public string? Type { get; set; }
    public DateTime? FifoDate { get; set; }
    public string? CycleCountClass { get; set; }
    public DateTime? LastCountDate { get; set; }
    public DateTime? LastPhysicalDate { get; set; }
    public int? UserCount { get; set; }
    public double? CapacityVolume { get; set; }
    public double? TimeBetweenMaintenance { get; set; }
    public DateTime? LastMaintained { get; set; }
    public double? Length { get; set; }
    public double? Width { get; set; }
    public double? Height { get; set; }
    public string? ReplenishmentLocationId { get; set; }
    public string? PickArea { get; set; }
    public bool? AllowBulkPick { get; set; }
    public int? SlotRank { get; set; }
    public string? SlotStatus { get; set; }
    public string? ItemHuIndicator { get; set; }
    public string? C1 { get; set; }
    public string? C2 { get; set; }
    public string? C3 { get; set; }
    public string? RandomCc { get; set; }
    public double? XCoordinate { get; set; }
    public double? YCoordinate { get; set; }
    public double? ZCoordinate { get; set; }
    public string? StorageDeviceId { get; set; }
    public string? EquipmentType { get; set; }
    public string? LocationGroup { get; set; }
    public DateTime? LastActivityDate { get; set; }
    public string? NmIoLocationId { get; set; }
    public string? NmClosestDoor { get; set; }
    public string? NmHallId { get; set; }
    public string? NmBeam { get; set; }
    public string? NmSection { get; set; }
    public string? NmAisle { get; set; }
    public string? NmPutawayFlow { get; set; }
    public string? NmDangArea { get; set; }
    public bool? NmHighLift { get; set; }
    public bool? NmIsMezzanine { get; set; }
    public bool? NmIsBlockStack { get; set; }
    public bool? NmIsSelected { get; set; }
    public string? NmVoiceHall { get; set; }
    public string? NmVoiceAisle { get; set; }
    public string? NmVoiceSection { get; set; }
    public string? NmVoicePosition { get; set; }
    public string? NmVoiceLevel { get; set; }
}

}