namespace OnlineNewsWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tablecreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Advertisement",
                c => new
                    {
                        ADId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Image2 = c.String(),
                        Link = c.String(),
                        AltText = c.String(),
                    })
                .PrimaryKey(t => t.ADId);
            
            CreateTable(
                "dbo.Feedback",
                c => new
                    {
                        FeedbackID = c.Int(nullable: false, identity: true),
                        InternationalNewsID = c.Int(nullable: false),
                        FeedbackComment = c.String(),
                    })
                .PrimaryKey(t => t.FeedbackID);
            
            CreateTable(
                "dbo.International",
                c => new
                    {
                        InternationalNewsID = c.Int(nullable: false, identity: true),
                        CategoryID = c.Int(nullable: false),
                        NewsType = c.String(),
                        HeadLine = c.String(),
                        SubHeadLine = c.String(),
                        Country = c.String(),
                        DatePosted = c.String(),
                        SourceName = c.String(),
                        NewsContent = c.String(),
                        Image3 = c.String(),
                        Video = c.String(),
                        AdditionalComment = c.String(),
                        SubscriptionBased = c.String(),
                    })
                .PrimaryKey(t => t.InternationalNewsID);
            
            CreateTable(
                "dbo.NewsCategories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Subscribers",
                c => new
                    {
                        subscriber_id = c.Int(nullable: false, identity: true),
                        user_id = c.Int(nullable: false),
                        Subscription_Type = c.String(),
                        DateJoined = c.String(),
                        Mode_Of_Payment = c.String(),
                        User_Status = c.String(),
                    })
                .PrimaryKey(t => t.subscriber_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Subscribers");
            DropTable("dbo.NewsCategories");
            DropTable("dbo.International");
            DropTable("dbo.Feedback");
            DropTable("dbo.Advertisement");
        }
    }
}
