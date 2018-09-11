namespace hooliee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetNameOfMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'one time' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET Name = 'weekly' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET Name = 'monthly' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET Name = 'yearly' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
