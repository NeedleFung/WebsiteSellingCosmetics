﻿namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOrder : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Order", "TotalAmount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Order", "TotalAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
