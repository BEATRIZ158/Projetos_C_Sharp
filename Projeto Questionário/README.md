# Projeto Questionário 🧾

Olá pessoal! Dentro desta pasta temos o Projeto Questionário, que está sendo desenvolvido durante as aulas de Laboratório de Engenharia de Software, do 5ª Semestre de ADS na Fatec Prof. José Camargo.
Consiste no desenvolvimento de uma aplicação desktop para criação de questionários escolares para alunos, a aplicação possui três tipos diferentes de usuários, sendo eles 'Aluno', 'Professor' e 'Administrador', e cada um deles possui suas permissões de acesso e uso. Para esse projeto foi utilizado o SGBD PgAdmin 4 que fornece acesso ao banco PostgreSQL, ambos são Open Source.

## Explicação sobre as pastas e seus arquivos

**Modelo de Classes**

Essa pasta contém o arquivo do Diagrama de Classes, desenvolvido no Astah UML para o projeto.

**Projeto Questionário**

Essa pasta contém os arquivos e pastas necessários para o funcionamento da aplicação. Dentro dela temos mais algumas pastas que contém arquivos importantes.

*Controller*

Nessa pasta estão os arquivos .cs (C Sharp). Alguns desses arquivos são o controlleLogin.cs, controllerCategoria.cs e controllerUsuario.cs, em resumo esses arquivos contém as classes e seus atributos e métodos, que podem ser usados por suas instâncias, é dentro da Controller que é realizados alguns métodos de conexão com o Banco de dados, funções como inserir, alterar e excluir são definidos aqui.

*img* 

Onde estão os arquivos de Imagem do projeto, que são usados para a estilização da aplicação.

*Model* 

Dentro desta pasta estão os arquivos model, casa arquivo representa um modelo, cada modelo possui seus atributos, seus atributos são privados e podem ser acessados através da criação de uma instância de objeto que permite o acesso a esses atributos, essas instâncias recebem os valores que vem dos Form's, passam para a controller, que passam para o banco e suas tabelas, para que os dados sejam armazenados ou manipulados.

*View*

Dentro da pasta View estão os Forms e os arquivos .cs deles, nessa pasta contém arquivos relacionais a parte visual da aplicação.

*Screns* 

Essa pasta contém as imagens das telas que são apresentadas neste README.

## Capturas de Tela

### Tela de Login
![Tela Login](Screns/Tela%20Login.png)

### Tela Principal Padrão
![Tela Principal Padrão](Screns/Tela%20Principal%20Padrão.png)

### Tela Categoria - Nova Categoria
![Tela Categoria - Nova Categoria](Screns/Tela%20Categoria%20-%20Nova%20Categoria.png)

### Tela Categoria - Pesquisar Categoria
![Tela Categoria - Pesquisar Categoria](Screns/Tela%20Categoria%20-%20Pesquisar.png)

### Tela Categoria - Editar Categoria
![Tela Categoria - Editar Categoria](Screns/Tela%20Categoria%20-%20Editar.png)
