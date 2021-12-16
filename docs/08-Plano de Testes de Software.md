# Plano de Testes de Software

Para realização dos casos de teste, serão necessários alguns requisitos:

* Site já publicado
* Navegador da internet - Chrome ou Edge
* Conectividade com internet
* Massa de dados gerada em banco de dados. 

*Os testes funcionais serão realizados conforme descrito abaixo:
 
 
 |`CASO DE TESTE`| CT01 Login com sucesso de usuário cadastrado|
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF-01 O site deve apresentar uma página de login para autenticação de usuários cadastrados|
 |`OBJETIVO DO TESTE`| Verificar se o usuário consegue realizar o login com e-mail e senha corretas.|
 |`MASSA DE TESTE`|Usuário teste cadastrado do sistema <br> Email: teste.animescode@gmail.com <br>Senha: Animescode@1|
 |`PASSOS`| * Acessar o Navegador<br> * Informar a Url do site <br> * Visualizar a página principal <br> * Realizar Login <br> * Realizar pesquisa de animes pelos filtros citados em Requisitos Associados|
 |`CRITÉRIOS DE ÉXITO`| O usuário consegue acessar a plataforma com sucesso.|
 <br>
 
 |`CASO DE TESTE`| CT02 Login sem sucesso de usuário cadastrado|
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF-08 O acesso ao conteúdo do site será permitido apenas, a usuário previamente cadastrados.|
 |`OBJETIVO DO TESTE`| Verificar se o usuário consegue realizar o login com e-mail e senha incorretos.|
 |`MASSA DE TESTE`|Login inválido e senha válida <br> E-mail: naruto.top@gmail.com <br> Senha: Animescode@1|
 |`PASSOS`| * Acessar o Navegador <br> * Informar a Url do site <br> * Visualizar a página principal <br> * Informar login errado e senha correta|
 |`CRITÉRIOS DE ÉXITO`| O sistema deve emitir a mensagem "e-mail ou senha incorretos"|

 <br>
 
 |`CASO DE TESTE`| CT03 Login sem sucesso de usuário cadastrado|
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF-08 O acesso ao conteúdo do site será permitido apenas, a usuário previamente cadastrados.|
 |`OBJETIVO DO TESTE`| Verificar se o usuário consegue realizar o login com e-mail e senha incorretos.|
 |`MASSA DE TESTE`|Login válido e senha inválida <br> E-mail: teste.animescode@gmail.com <br Senha: Tanjiro01*|
 |`PASSOS`| * Acessar o Navegador <br> * Informar a Url do site <br> * Visualizar a página principal <br> * Informar login válido e senha incorreta|
 |`CRITÉRIOS DE ÉXITO`| O sistema deve emitir a mensagem "e-mail ou senha incorretos"|
 
 <br>

 |`CASO DE TESTE`| CT04 Cadastro de novos usuários|
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF - 02 O site deve apresentar um link na página de login para cadastro de novos usuários através de um formulário. Este formulário deve conter: * Nome <br> * Data de nascimento <br> * E-mail <br> * Confirmar e-mail <br> * Senha <br> * Confirmar Senha.|
 |`OBJETIVO DO TESTE`| * Verificar se o formulário de cadastro é exibido para novos usuários, quando este acessa o link. <br> * Verificar se os campos citados em *Requisitos Associados*, estão sendo exibidos corretamente. <br> * Verificar se o usuário consegue logar após o cadastro.|
 |`MASSA DE TESTE`|Será gerada durante o teste.|
 |`PASSOS`|* Acessar o Navegador Informar a Url do site <br> * Visualizar a página principal <br> * Clicar no link para cadastro de novos usuários <br> * Realizar cadastro completo <br> * Efetuar login|
 |`CRITÉRIOS DE ÉXITO`|  O sistema deve permitir o cadastro de um novo usuário e liberar o seu acesso.|
 
<br>
 

 |`CASO DE TESTE`| CT05 Criação de domínio de administrador|
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF-08| Deverá ser criado um domínio de administrador para criação dos animes e suas descrições|
 |`OBJETIVO DO TESTE`| Verificar a autenticação do domínio de administrador e sua criação em banco de dados|
 |`MASSA DE TESTE`|Usuário teste cadastrado do sistema <br> Email:Admin <br> Senha: ****** |
 |`PASSOS`| * Acessar o Navegador <br> * Informar a Url do site <br> * Visualizar a página principal <br> * Realizar Login com dominío admin <br> * Verificar se o mesmo possui a autorização para adição de animes e suas descrições|
 |`CRITÉRIOS DE ÉXITO`|O sistema deve permitir o login do admin e o cadastro de animes.|
 <br>
  
 |`CASO DE TESTE`|CT06 Administrador poder criar, alterar e excluir gêneros de anime.|
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF-04 O site deve possibilitar que o administrador crie, altere e exclua gêneros.|
 |`OBJETIVO DO TESTE`| Verificar se o radius para essas funções estão clicáveis e funcionando.  |
 |`MASSA DE TESTE`|Usuário admin cadastrado do sistema <br> Email: adm@gmail.com <br> Senha: 123|
 |`PASSOS`|* Acessar o Navegador <br> * Informar a Url do site <br> * Visualizar a página principal <br> * Realizar Login <br> * Acessar Adicionar gênero <br> * Criar um novo gênero <br> * Clicar em editar esse gênero criado <br> * Excluir gênero que acabou de ser criado .|
 |`CRITÉRIOS DE ÉXITO`|O sistema deve reconhecer todas as funcionalidades faladas acima.|

 <br>
  
 |`CASO DE TESTE`|CT07 Administrador poder visualizar e excluir usuários.|
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF-04 O site deve possibilitar que o administrador visualize e exclua usuários.|
 |`OBJETIVO DO TESTE`| Verificar se o radius para essas funções estão clicáveis e funcionando.  |
 |`MASSA DE TESTE`|Usuário admin cadastrado do sistema <br> Email: adm@gmail.com <br> Senha: 123|
 |`PASSOS`|* Acessar o Navegador <br> * Informar a Url do site <br> * Visualizar a página principal <br> * Realizar Login <br> * Acessar Visualizar Usuários <br> * Verificar se será listado os usuários <br> * Excluir algum usuário .|
 |`CRITÉRIOS DE ÉXITO`|O sistema deve reconhecer todas as funcionalidades reproduzindo a lista de usuários e excluindo com êxito um usuário.|
 
 <br>
  
 |`CASO DE TESTE`|CT08 Administrador poder editar animes. |
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF-07 O site deve possibilitar que o administrador edite animes.|
 |`OBJETIVO DO TESTE`| Verificar se o radius para essas funções estão clicáveis e funcionando.  |
 |`MASSA DE TESTE`|Usuário admin cadastrado do sistema <br> Email: teste.animescode@gmail.com <br> Senha: Animescode@1|
 |`PASSOS`|* Acessar o Navegador <br> * Informar a Url do site <br> * Visualizar a página principal <br> * Clicar em algum anime <br> * Clicar no botão de editar anime <br> * Realizar a edição de algum campo <br> * Verificar se o campo foi alterado..|
 |`CRITÉRIOS DE ÉXITO`| O sistema deve realizar a alteração com êxito, e ser verificada essa alteração.|
 
 <br>
 
 |`CASO DE TESTE`|CT9 Logout com sucesso de usuário logado .|
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF-01 O site deve apresentar um botão de Sair, e fazer logout do site, voltando para tela de login .|
 |`OBJETIVO DO TESTE`| Verificar se o usuário será desconectado e voltará para página de login .|
 |`MASSA DE TESTE`|Usuário teste cadastrado do sistema <br> Email: adm@gmail.com <br>Senha: 123|
 |`PASSOS`| * Acessar o Navegador<br> * Informar a Url do site <br> * Visualizar a página principal <br> * Realizar Login <br> * Clicar no botão Sair<br> |
 |`CRITÉRIOS DE ÉXITO`| O usuário será deslogado com sucesso e voltará para a tela de login.|
  <br>

 
