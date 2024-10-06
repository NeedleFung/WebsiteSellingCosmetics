﻿namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSubscribe : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Subscribe", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Subscribe", "Email", c => c.String());
        }
    }
}
