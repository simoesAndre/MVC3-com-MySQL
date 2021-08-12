# MVC3-com-MySQL
Atividade de ASP.NET Core MVC com MySQL (Curso Técnico de Informática para a Internet)

Está atividade que eu desenvolvi consiste em um projeto MVC de cadastro de usuários e pacotes turísticos em uma agência de viagens. 
O projeto tem conexão com banco de dados através do MySQL. O site possui 25 páginas que são:

1. Página inicial com alguns pacotes turísticos em destaque;
2. Página institucional. Nela contêm informações sobre a empresa (quem somos, missão, visão e valores);
3. Página de contato que contêm o endereço da empresa;
4. Página de carrinho de compras;
5. Página de login. Nela o usuário informa o nome e a senha para entrar no sistema.
6. Página de logado. Nela são exibidas ações que o usuário pode realizar;
7. Página de cadastro de usuário. Nela são registradas as seguintes informações: nome, data de nascimento, login, senha, 
tipo de usuário (administrador ou comum). Somente usuário administrador pode cadastrar outros usuários;
8. Página de informação de sucesso 1. Está página aparece logo depois que o cadastro ocorre. Além da mensagem, são exibidas ações que o usuário pode realizar;
9. Página de edição de usuário. Nela pode ser feito alterações nas seguintes informações do usuário: nome, data de nascimento, login, senha, 
tipo de usuário (administrador ou comum). Somente usuário administrador pode editar outros usuários;
10. Página de informação de sucesso 2. Está página aparece logo depois que a edição ocorre. Além da mensagem, são exibidas ações que o usuário pode realizar;
11. Página de exclusão de usuário. Nela pode ser feita a exclusão de um usuário, basta informar o id do usuário que deseja excluir. Somente usuário administrador 
pode exluir outros usuários;
12. Página de informação de sucesso 3. Está página aparece logo depois que a exclusão ocorre. Além da mensagem, são exibidas ações que o usuário pode realizar;
13. Página de listagem de usuários. Nela são mostradas as informações de todos os usuários salvos no banco de dados. Somente usuário administrador 
pode acessar a lista de usuários;
14. Página de acesso negado 1. Ela aparece caso um usuário comum tentar cadastrar outro usuário;
15. Página de acesso negado 2. Ela aparece caso um usuário comum tentar ver a lista de usuários;
16. Página de acesso negado 3. Ela aparece caso um usuário comum tentar editar outro usuário;
17. Página de acesso negado 4. Ela aparece caso um usuário comum tentar excluir outro usuário;
18. Página de cadastro de pacote turístico. Nela são registradas as seguintes informações: nome, origem, destino, atrativos, data de saída, data de retorno, 
id do usuário que está cadastrando. Todos os usuários podem cadastrar pacotes turísticos;
19. Página de informação de sucesso 4. Está página aparece logo depois que o cadastro ocorre. Além da mensagem, são exibidas ações que o usuário pode realizar;
20. Página de edição de pacote turístico. Nela pode ser feito alterações nas seguintes informações do pacote turísticos: nome, origem, destino, atrativos, 
data de saída, data de retorno, id do usuário que está cadastrando. Todos os usuários podem editar pacotes turísticos;
21. Página de informação de sucesso 5. Está página aparece logo depois que a edição ocorre. Além da mensagem, são exibidas ações que o usuário pode realizar;
22. Página de exclusão de pacote turístico. Nela pode ser feita a exclusão de um pacote turístico, basta informar o id do pacote que deseja excluir. 
Todos os usuários podem excluir pacotes turísticos;
23. Página de informação de sucesso 6. Está página aparece logo depois que a edição ocorre. Além da mensagem, são exibidas ações que o usuário pode realizar;
24. Página de listagem de pacotes turísticos. Nela são mostradas as informações de todos os pacotes salvos no banco de dados. Todos os usuários 
podem acessar a lista de pacotes;
25. Página de logout. Ela aparece depois que o usuário seleciona a ação de sair do sistema. Ésta página a ação de entrar novamente no sistema.
