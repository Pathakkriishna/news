namespace DMS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_new_table : DbMigration
    {
        public override void Up()
        {
            Sql(@"create table employee(
                id int primary key identity(1,1),
                name nvarchar(30) NOT NULL,
                address nvarchar(40) NOT NULL
               
            );");
        }
        
        public override void Down()
        {
        }
    }
}
