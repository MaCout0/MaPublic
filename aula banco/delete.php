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

	$delete = mysqli_query($con, "DELETE FROM clientes WHERE email = 'bruna@gmail.com'");
	$alter = mysqli_query($con, "ALTER TABLE clientes AUTO_INCREMENT = 1");
	$alter2 = mysqli_query($con, "ALTER TABLE chamados AUTO_INCREMENT = 1");