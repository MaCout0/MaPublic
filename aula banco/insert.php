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

	$insert = mysqli_query($con, "INSERT INTO clientes (nome, email, telefone) VALUES ('MaCouto', 'jkmbint@gmail.com', '(49)99999-9999')");

	if($insert) {
		$clientes_id = mysqli_insert_id($con);

		mysqli_query($con, "INSERT INTO chamados (clientes_id, mensagem, data, status) VALUES ('$clientes_id', 'mensagem de teste', NOW(), 0)");
	}
?>