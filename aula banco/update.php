<?php 
	//host
	//nome de usuario
	//senha
	//nome do banco
	$con = mysqli_connect('localhost', 'root', '', 'base_data');

	// verifica a conexão
	if (mysqli_connect_errno()) {
		echo "A conexão falhou" . mysqli_connect_error();
	} else {
		echo "Conectado";
	}

	$update = mysqli_query($con, "UPDATE clientes SET nome = 'Bruna', email = 'bruna@gmail.com' WHERE email = 'jkmbint@gmail.com'");