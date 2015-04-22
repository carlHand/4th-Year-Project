namespace TrainGainV1.DataContexts.ApplicationMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NotesAndDuration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SportProgram", "PreTrainingNotes", c => c.String());
            AddColumn("dbo.SportProgram", "DurationInfo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SportProgram", "DurationInfo");
            DropColumn("dbo.SportProgram", "PreTrainingNotes");
        }
    }
}
