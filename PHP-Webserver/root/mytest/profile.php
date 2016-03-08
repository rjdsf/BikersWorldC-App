	<?php
	session_start();

	?>
	
	<!DOCTYPE html>
	<html lang="en">
	<head>
	<title>My PHP Stuff</title>
	<link rel="stylesheet" href="styles.css" type="text/css">
	<meta charset="UTF-8">
	</head>
	<body>
	<div id="container">
	<header></header>
	<?php include ('navigation.php') ?>
	<section id="main">
	<?php echo "Welcome " . $_SESSION['user']; ?>
	</section>
	<footer>
	</footer>
	<!-- close container --></div>
	</body>
	</html>