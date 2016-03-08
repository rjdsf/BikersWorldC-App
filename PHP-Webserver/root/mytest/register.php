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
		<form method="post" action="register_action.php" name="register">
		<fieldset>
		<legend>Register</legend>
		<br>
		<label>Full Name</label><input type="text" name="name"><br>
		<label>Email</label><input type="text" name="email"><br>
		<label>Password</label><input type="password" name="password1"><br>
		<label>Confirm Password</label><input type="password" name="password2"><br>
		<label>Date of Birth (yyyy-mm-dd):</label><input type="date" name="date_of_birth"><br>
		<label>Information</label><input type="text" name="information"><br>
		<label>Nationality</label><input type="text" name="nationality"><br>
		<input type="submit" value="register">
			</fieldset>
			</form>
	</section>
	<footer>
	</footer>
	<!-- close container --></div>
	</body>
	</html>