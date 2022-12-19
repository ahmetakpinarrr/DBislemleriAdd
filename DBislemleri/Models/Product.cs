using System;
using System.Collections.Generic;

#nullable disable

namespace Dbislemleri.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductFullName { get; set; }
        public string ProductCode { get; set; }
        public string ProdyctSlug { get; set; }
        public int? ProductIsActive { get; set; }
        public string ProductBarcode { get; set; }
        public string ProductStockCode { get; set; }
        public int? ProductStockAmount { get; set; }
        public int? ProductStockType { get; set; }
        public decimal ProductPrice1 { get; set; }
        public int? ProductWarranty { get; set; }
        public int? ProductDiscount { get; set; }
        public int? ProductDiscountType { get; set; }
        public int? ProductTaxIncluded { get; set; }
        public string ProductDistributor { get; set; }
        public int? ProductIsGifted { get; set; }
        public string ProductThumbnail { get; set; }
        public string ProductGift { get; set; }
        public int? ProductCustomShippingDisabled { get; set; }
        public decimal? ProductCustomShippingCost { get; set; }
        public decimal? ProductMarketPriceDetail { get; set; }
        public int ProductCategoryId { get; set; }
        public int? ProductSubCategoryId { get; set; }
        public int? ProductTax { get; set; }
        public decimal? ProductBuyingPrice { get; set; }
        public int? ProductBrandId { get; set; }
        public string ProductTitle { get; set; }
        public string ProductShortDetails { get; set; }
        public string ProductDescription { get; set; }
        public string ProductMetaKeywords { get; set; }
        public string ProductMetaDescription { get; set; }
        public string ProductSearchKeywords { get; set; }
        public string ProductPageTitle { get; set; }
        public int? ProductHasOption { get; set; }
        public int? ProductUnitId { get; set; }
        public DateTime? ProductCreateDate { get; set; }
        public DateTime? ProductUpdateDate { get; set; }
        public string ProductInstallmentThreshold { get; set; }
        public int? ProductHomeSortOrder { get; set; }
        public int? ProductPopularSortOrder { get; set; }
        public int? ProductBrandSortOrder { get; set; }
        public int? ProductFeaturedSortOrder { get; set; }
        public int? ProductCampaignedSortOrder { get; set; }
        public int? ProductNewSortOrder { get; set; }
        public int? ProductDiscountedSortOrder { get; set; }
        public int? ProductImageId { get; set; }
        public double? ProdRate { get; set; }
        public int? ProdRateUserCount { get; set; }
    }
}
