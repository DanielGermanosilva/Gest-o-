use gestao
go

select*from Usuario

insert into Usuario (nome, NomeUsuario, cpf, Email, Senha, Ativo) 
values (@nome, @nomeusuario, @cpf, @email, @senha, @ativo)