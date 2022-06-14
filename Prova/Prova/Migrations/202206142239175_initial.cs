namespace Prova.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FornecedorModels",
                c => new
                    {
                        FornecedorId = c.Long(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Email = c.String(),
                        Logradouro = c.String(),
                        Numero = c.String(),
                        Complemento = c.String(),
                        Bairro = c.String(),
                        Cidade = c.String(),
                        Produto_ProdutoId = c.Long(),
                    })
                .PrimaryKey(t => t.FornecedorId)
                .ForeignKey("dbo.ProdutoModels", t => t.Produto_ProdutoId)
                .Index(t => t.Produto_ProdutoId);
            
            CreateTable(
                "dbo.ProdutoModels",
                c => new
                    {
                        ProdutoId = c.Long(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.ProdutoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FornecedorModels", "Produto_ProdutoId", "dbo.ProdutoModels");
            DropIndex("dbo.FornecedorModels", new[] { "Produto_ProdutoId" });
            DropTable("dbo.ProdutoModels");
            DropTable("dbo.FornecedorModels");
        }
    }
}
