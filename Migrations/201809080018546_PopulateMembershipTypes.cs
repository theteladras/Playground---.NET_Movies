namespace hooliee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (id, SignUpFee, DurationInMonths, DiscountRate) VALUES (1, 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (id, SignUpFee, DurationInMonths, DiscountRate) VALUES (2, 20, 3, 30)");
            Sql("INSERT INTO MembershipTypes (id, SignUpFee, DurationInMonths, DiscountRate) VALUES (3, 60, 4, 120)");
            Sql("INSERT INTO MembershipTypes (id, SignUpFee, DurationInMonths, DiscountRate) VALUES (4, 80, 12, 40)");
        }
        
        public override void Down()
        {
        }
    }
}
