using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCursosUeceMy.Migrations
{
    /// <inheritdoc />
    public partial class popularDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Insert into ""Curso""(""Id"",""Titulo"", ""Descricao"", ""NomeInstrutor"", ""QtdAulas"", ""Preco"") Values('f14e4d44-6f1f-44e7-b61e-7df6b0bd6829', 'C#', 'Curso c#', 'Jefferson', 5, 25)");
            migrationBuilder.Sql(@"Insert into ""Curso""(""Id"",""Titulo"", ""Descricao"", ""NomeInstrutor"", ""QtdAulas"", ""Preco"") Values('7fd7170a-cb9b-4873-86b5-1233b3b8a401', 'Jva', 'Curso Java', 'andre', 5, 30)");
            migrationBuilder.Sql(@"Insert into ""Curso""(""Id"",""Titulo"", ""Descricao"", ""NomeInstrutor"", ""QtdAulas"", ""Preco"") Values('d5144188-02f6-48fc-b885-451e70c0d0d9', 'React', 'Curso react', 'JB', 5, 35)");
            
            migrationBuilder.Sql(@"Insert into ""Aula""(""Id"",""Ordem"", ""Titulo"", ""Duracao"", ""IdRecursoStream"", ""CursoId"") Values('e4ddb0e7-a859-4f81-af87-3d4b6708284f', 1, 'Aula 01 C#', '05:02', '47b7ed46-828b-4ec5-9b6a-8afa4435f3f0', 'f14e4d44-6f1f-44e7-b61e-7df6b0bd6829')");
            migrationBuilder.Sql(@"Insert into ""Aula""(""Id"",""Ordem"", ""Titulo"", ""Duracao"", ""IdRecursoStream"", ""CursoId"") Values('cc3b2bbb-0cf3-4f75-b79f-418402ecc36c', 2, 'Aula 02 C#', '05:02', '47b7ed46-828b-4ec5-9b6a-8afa4435f3f0', 'f14e4d44-6f1f-44e7-b61e-7df6b0bd6829')");
            migrationBuilder.Sql(@"Insert into ""Aula""(""Id"",""Ordem"", ""Titulo"", ""Duracao"", ""IdRecursoStream"", ""CursoId"") Values('484bc4ae-45ac-4741-961d-39726e8ecc73', 3, 'Aula 03 C#', '05:02', '47b7ed46-828b-4ec5-9b6a-8afa4435f3f0', 'f14e4d44-6f1f-44e7-b61e-7df6b0bd6829')");       

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"delete from ""Curso""");
            migrationBuilder.Sql(@"delete from ""Aula""");
        }
    }
}
