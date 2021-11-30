# Plano de Testes de Software

Para realização dos casos de teste, serão necessários alguns requisitos:

* Site já publicado
* Navegador da internet - Chrome ou Edge
* Conectividade com internet
* Massa de dados gerada em banco de dados. 

Os testes funcionais serão realizados conforme descrito abaixo:
 
 
 |`CASO DE TESTE`| CT01 Login com sucesso de usuário cadastrado|
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF-01 O site deve apresentar uma página de login para autenticação de usuários cadastrados|
 |`OBJETIVO DO TESTE`| Verificar se o usuário consegue realizar o login com e-mail e senha corretas.|
 |`MASSA DE TESTE`|Usuário teste cadastrado do sistema <br> Email: teste.animescode@gmail.com <br>Senha: Animescode@1|
 |`PASSOS`| * Acessar o Navegador<br> * Informar a Url do site <br> * Visualizar a página principal <br> * Realizar Login <br> * Realizar pesquisa de animes pelos filtros citados em Requisitos Associados|
 |`CRITÉRIOS DE ÉXITO`| O usuário consegue acessar a plataforma com sucesso.|
 <br>

 https://user-images.githubusercontent.com/78831493/139751840-c82d6c05-d4a4-4150-a424-d2282f79c8be.mp4 
 
 *Evidência de teste*

<br>
 
 |`CASO DE TESTE`| CT02 Login sem sucesso de usuário cadastrado|
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF-08 O acesso ao conteúdo do site será permitido apenas, a usuário previamente cadastrados.|
 |`OBJETIVO DO TESTE`| Verificar se o usuário consegue realizar o login com e-mail e senha incorretos.|
 |`MASSA DE TESTE`|Login inválido e senha válida <br> E-mail: naruto.top@gmail.com <br> Senha: Animescode@1|
 |`PASSOS`| * Acessar o Navegador <br> * Informar a Url do site <br> * Visualizar a página principal <br> * Informar login errado e senha correta|
 |`CRITÉRIOS DE ÉXITO`| O sistema deve emitir a mensagem "e-mail ou senha incorretos"|

 ![TelaLoginUsuarioInvalido](https://user-images.githubusercontent.com/78831493/139755171-64a1c31d-bb6d-4d61-8f35-ed6b1e713c4b.jpeg)

 *Evidência de teste*
 
 <br> <br>
 
 |`CASO DE TESTE`| CT03 Login sem sucesso de usuário cadastrado|
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF-08 O acesso ao conteúdo do site será permitido apenas, a usuário previamente cadastrados.|
 |`OBJETIVO DO TESTE`| Verificar se o usuário consegue realizar o login com e-mail e senha incorretos.|
 |`MASSA DE TESTE`|Login válido e senha inválida <br> E-mail: teste.animescode@gmail.com <br Senha: Tanjiro01*|
 |`PASSOS`| * Acessar o Navegador <br> * Informar a Url do site <br> * Visualizar a página principal <br> * Informar login válido e senha incorreta|
 |`CRITÉRIOS DE ÉXITO`| O sistema deve emitir a mensagem "e-mail ou senha incorretos"|
 
 ![TelaLoginUsuarioInvalido](https://user-images.githubusercontent.com/78831493/139755171-64a1c31d-bb6d-4d61-8f35-ed6b1e713c4b.jpeg)

 *Evidência de teste*
 
 <br> <br>
 
 |`CASO DE TESTE`| CT04 Login sem sucesso de usuário cadastrado|
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF-08 O acesso ao conteúdo do site será permitido apenas, a usuário previamente cadastrados.|
 |`OBJETIVO DO TESTE`| Verificar se o usuário consegue realizar o login com e-mail e senha incorretos.|
 |`MASSA DE TESTE`|Login e senha inválidos <br> E-mail: naruto.top@gmail.com <br> Senha: Tanjiro01*|
 |`PASSOS`| * Acessar o Navegador <br> * Informar a Url do site <br> * Visualizar a página principal <br> * Informar login e senha inválidos|
 |`CRITÉRIOS DE ÉXITO`| O sistema deve emitir a mensagem "e-mail ou senha incorretos"|
 
 ![TelaLoginUsuarioInvalido](https://user-images.githubusercontent.com/78831493/139755171-64a1c31d-bb6d-4d61-8f35-ed6b1e713c4b.jpeg)

 *Evidência de teste*
 
<br> <br>

 |`CASO DE TESTE`| CT05 Cadastro de novos usuários|
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF - 02 O site deve apresentar um link na página de login para cadastro de novos usuários através de um formulário. Este formulário deve conter: * Nome <br> * Data de nascimento <br> * E-mail <br> * Confirmar e-mail <br> * Senha <br> * Confirmar Senha.|
 |`OBJETIVO DO TESTE`| * Verificar se o formulário de cadastro é exibido para novos usuários, quando este acessa o link. <br> * Verificar se os campos citados em *Requisitos Associados*, estão sendo exibidos corretamente. <br> * Verificar se o usuário consegue logar após o cadastro.|
 |`MASSA DE TESTE`|Será gerada durante o teste.|
 |`PASSOS`|* Acessar o Navegador Informar a Url do site <br> * Visualizar a página principal <br> * Clicar no link para cadastro de novos usuários <br> * Realizar cadastro completo <br> * Efetuar login|
 |`CRITÉRIOS DE ÉXITO`|  O sistema deve permitir o cadastro de um novo usuário e liberar o seu acesso.|
 
 

 https://user-images.githubusercontent.com/75825162/143967553-7a18d090-ff61-4833-8948-26a8135330b4.mp4
  
 *Evidência de teste*
 
 <br> <br>
 

 
 |`CASO DE TESTE`| CT06 Criação de domínio de administrador|
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF-08| Deverá ser criado um domínio de administrador para criação dos animes e suas descrições|
 |`OBJETIVO DO TESTE`| Verificar a autenticação do domínio de administrador e sua criação em banco de dados|
 |`MASSA DE TESTE`|Usuário teste cadastrado do sistema <br> Email:Admin <br> Senha: ****** |
 |`PASSOS`| * Acessar o Navegador <br> * Informar a Url do site <br> * Visualizar a página principal <br> * Realizar Login com dominío admin <br> * Verificar se o mesmo possui a autorização para adição de animes e suas descrições|
 |`CRITÉRIOS DE ÉXITO`|O sistema deve permitir o login do admin e o cadastro de animes.|
 
 ![image](https://user-images.githubusercontent.com/75825162/143968178-a3560817-5fe4-41ee-8e38-7f6b60c67271.png)
 
 ![image](https://user-images.githubusercontent.com/75825162/143968252-9b9e7bd7-1c1d-4e1f-8e91-696e381004c9.png)



  <br> <br>
  
 |`CASO DE TESTE`|CT07  Criar, alterar e excluir gêneros de anime.|
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF-04 O site deve possibilitar que o administrador crie, altere e exclua gêneros.|
 |`OBJETIVO DO TESTE`| Verificar se o radius para essas funções estão clicáveis e funcionando.  |
 |`MASSA DE TESTE`|Usuário teste cadastrado do sistema <br> Email: adm@gmail.com <br> Senha: 123|
 |`PASSOS`|* Acessar o Navegador <br> * Informar a Url do site <br> * Visualizar a página principal <br> * Realizar Login <br> * Acessar Adicionar gênero <br> * Criar um novo gênero <br> * Clicar em editar esse gênero criado <br> * Excluir gênero que acabou de ser criado .|
 |`CRITÉRIOS DE ÉXITO`|O sistema deve reconhecer todas as funcionalidades faladas acima.|

 https://user-images.githubusercontent.com/75825162/143969311-c5fad904-220b-41d9-9831-0f9801e1da91.mp4
 
  <br> <br>
  
 |`CASO DE TESTE`|CT08  Visualizar e excluir usuários.|
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF-04 O site deve possibilitar que o administrador visualize e exclua usuários.|
 |`OBJETIVO DO TESTE`| Verificar se o radius para essas funções estão clicáveis e funcionando.  |
 |`MASSA DE TESTE`|Usuário teste cadastrado do sistema <br> Email: adm@gmail.com <br> Senha: 123|
 |`PASSOS`|* Acessar o Navegador <br> * Informar a Url do site <br> * Visualizar a página principal <br> * Realizar Login <br> * Acessar Visualizar Usuários <br> * Verificar se será listado os usuários <br> * Excluir algum usuário .|
 |`CRITÉRIOS DE ÉXITO`|O sistema deve reconhecer todas as funcionalidades reproduzindo a lista de usuários e excluindo com êxito um usuário.|
 
 https://user-images.githubusercontent.com/75825162/143969898-67e468c1-44a3-4610-b429-63723a970348.mp4

  <br> <br>
  
 |`CASO DE TESTE`|CT09 Usuário avaliar com notas os animes assistidos. |
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF-07  O usuário só pode dar nota ao anime, após finalizá-lo.|
 |`OBJETIVO DO TESTE`|Verificar se o usuário está conseguindo avaliar o anime, apenas quando todos os episódios e temporadas estão marcados como concluído.|
 |`MASSA DE TESTE`|Usuário teste cadastrado do sistema <br> Email: teste.animescode@gmail.com <br> Senha: Animescode@1|
 |`PASSOS`|* Acessar o Navegador <br> * Informar a Url do site <br> * Visualizar a página principal <br> * Realizar Login <br> * Acessar lista de animes <br> * Acessar lista de animes <br> * Avaliar com nota anime já marcado como finalizado.|
 |`CRITÉRIOS DE ÉXITO`| O sistema deve permitir a avaliação apenas em animes já finalizados.|
 
 <br> <br>
 
 |`CASO DE TESTE`|CT10 Alteração do status pós marcação em anime.|
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF-09 O usuário poderá criar uma lista de animes que está assistindo no momento e marcar seu progresso que será diferenciado por cores. Animes já assistidos em verde, os animes em andamento de amarelo, animes para assistir depois em roxo.|
 |`OBJETIVO DO TESTE`|Verificar se o usuário está conseguindo avaliar o anime, apenas quando todos os episódios e temporadas estão marcados como concluído.|
 |`MASSA DE TESTE`|Usuário teste cadastrado do sistema <br> Email: teste.animescode@gmail.com <br> Senha: Animescode@1|
 |`PASSOS`|* Acessar o Navegador <br> * Informar a Url do site <br> * Visualizar a página principal <br> * Realizar Login <br> * Pesquisar anime <br> * Marca-lo como lido/em andamento/ver depois.|
 |`CRITÉRIOS DE ÉXITO`| O site deve possibilitar que o usuário marque as opçõeslido/em andamento/ver depois, no anime selecionado|
 
<br> <br>

 |`CASO DE TESTE`|CT12 Lista de animes em PDF|
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF-11 O site deve emitir uma lista com o nome” minha lista de animes”.|
 |`OBJETIVO DO TESTE`|Gerar uma lista em PDF com animes presentes na lista do usuário.|
 |`MASSA DE TESTE`|Usuário teste cadastrado do sistema <br> Email: teste.animescode@gmail.com <br> Senha: Animescode@1|
 |`PASSOS`|* Acessar o Navegador <br> * Informar a Url do site <br> * Visualizar a página principal <br> * Realizar Login <br> * Acessar area do usuario <br> * Clicar em minha lista <br> * Gerar arquivo PDF|
 |`CRITÉRIOS DE ÉXITO`|O sistema deve emitir um arquivo em PDF com os animes adicionados a lista do usuário. |


 
