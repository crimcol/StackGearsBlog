using FluentMigrator;

namespace DbMigrations
{
	[Migration(20221128222237)]
	public class SqlScriptMigration : Migration
	{
		public override void Up()
		{
			Execute.Script(@"Scripts\20221128222237_SqlScriptMigration.sql");
		}

		public override void Down()
		{
			Execute.Script(@"Scripts\20221128222237_SqlScriptMigration_Down.sql");
		}
	}
}  