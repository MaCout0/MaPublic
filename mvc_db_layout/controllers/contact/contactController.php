<?php
/*
*
*Controller do formulario de contato
*
*@autor Code Universe
*
*/
class ContactController extends Controller {

	//função para o cadastro de formulario
	public function submitContact() {

		$id = null;
		$name = $_POST['name'];
		$email = $_POST['email'];
		$phone = $_POST['phone'];
		$message = $_POST['message'];

		$saveContact = new ContactCrud;
		$saveContact = $saveContact->saveContact($id, $name, $email, $phone, $message);

		echo json_encode(array(
			'result' => $saveContact,
		));

	}

}