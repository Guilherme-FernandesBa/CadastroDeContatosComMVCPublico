# CadastroDeContatosMVC
Um sistema ASP.NET (5.0) utilizando do Entity framehowrk e Bootstrap para fazer um site com um CRUD de cadrastro de contatos com ligação a um banco de dados SQL Server.

Para rodar, baixe o EntityFramework Core, Tools, Desing e SQL Server, todos na versão 5.0
Popule o Appsettings.Json com o conection String do BD
"ConnectionStrings": {
    "Database": "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;"
    },

Rode o comando 
```Update-Database -Context BancoContext ```

Se o banco indicado existe ele será Atualizado, se não será criado com as tabelas no context para o funcionamento do programa

Após isso ele estará preparado para uso, Você iniciara e a HomePage tem algumas informações sobre mim e o programa, e seguindo para pagina de contatos verá a opção de criar novo e assim popular o banco, apartir do mometo que existe alguma informação na tabela o programa irá mostra-la na tela de contatos, e existirão opções de Editar ou apagar o contato, mexendo diretamente com as informações no BD.

O link de onde esse projeto foi inspirado está na pagina principal do mesmo.
