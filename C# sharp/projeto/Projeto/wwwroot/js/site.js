// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//Responsivo
var hamburger = function () {
	$('body').on('click', '.hamburger', function () {
		$('.links').toggle();
	})
}

$(document).ready(function () {
	hamburger();
})
