	<!DOCTYPE html>
	<html lang="en">
	<head>
	<title>My PHP Stuff</title>
	<link rel="stylesheet" href="styles.css" type="text/css">
	<meta charset="UTF-8">
	</head>
	<body>
	<div id="container">
	<header>Mini Facebook</header>
		<?php include ('navigation1.php') ?>
	<section id="main">
		<form method="post" action="login-action.php" name="login">
		<fieldset>
		<legend>Login</legend>
			<label for username>Username</label><input type="text" name ="username" size ="15"><br>
			<label for password>Password</label><input type="password" name ="password" size ="15"><br>
			<input type ="submit" value="Login" name="submit">
			</fieldset>
			</form>
	</section>
	<footer>
	</footer>
	<!-- close container --></div>
	</body>
	</html>