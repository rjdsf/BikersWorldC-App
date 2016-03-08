	<?php
//creating variables to store username and password
	$thisuser = filter_var($_POST['username'], FILTER_SANITIZE_STRING);
	$thispass = md5($_POST['password']);
	
//connect to database
	include "db.php";
	
//validate request to login to site, if user is not logged in - start session
	if(!isset($_SESSION))
	{
	session_start();
	}
	
//attempt login
	try {
	
	$sql = "SELECT UserID, user_name, user_password FROM users WHERE user_name= :username AND user_password= :password";
	$result = $pdo->prepare($sql);
	$result->bindParam(":username", $thisuser);
	$result->bindParam(":password", $thispass);
	$result->execute();
	}
	catch (PDOException $e) 
	{
	echo "Error !" . $e->getMessage() . "<br>";
	exit();
	}
	$num = $result->fetch(PDO::FETCH_ASSOC);
	
	if($num > 0){
	$_SESSION['user'] = $thisuser;
	$_SESSION['userid'] = $num['UserID'];
	header("location:profile.php");
	}
	
	else
	{
	header("location:tryagain.php");
	}
	?>