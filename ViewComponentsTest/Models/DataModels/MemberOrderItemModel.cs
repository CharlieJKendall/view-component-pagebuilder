using System;

namespace ViewComponentsTest.Models.DataModels
{
    public enum VoucherRedemptionStatus
    {
        Unredeemed = 0,
        Redeemed = 1
    }

    public class MemberOrderItemModel : Object
    {
        public int Id { get; set; }
        public VoucherRedemptionStatus RedemptionStatus { get; }
        public DateTime? ExpirationDate { get; }
        public string ShortDescription { get; }
        public string ImageURL { get; }
        public string ProductName { get; }
        public int GameNumber { get; }

        public MemberOrderItemModel(
            int id,
            VoucherRedemptionStatus redemptionStatus,
            string shortDescription,
            string imageUrl,
            string productName,
            int gameNumber,
            DateTime? expirationDate = null)
        {
            this.Id = id;
            this.RedemptionStatus = redemptionStatus;
            this.ExpirationDate = expirationDate;
            this.ShortDescription = shortDescription;
            this.ImageURL = imageUrl;
            this.ProductName = productName;
            this.GameNumber = gameNumber;
        }
    }
}
