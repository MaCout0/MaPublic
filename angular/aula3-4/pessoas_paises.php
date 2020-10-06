<?php

	$con = mysqli_connect('localhost', 'root', '', 'pessoas_paises');

	$select = mysqli_query($con, "SELECT * FROM pessoas");

	$response = array();

	$i = 0;

	while ($data = mysqli_fetch_array($select)) {
		$response[$i]['name']			= $data['name'];
		$response[$i]['country']		= $data['country'];
		$i++;
	}

	echo json_encode(

		array(
			'records' => $response
		)

	);