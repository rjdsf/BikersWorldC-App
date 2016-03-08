<?php 
	if((!isset($_GET['first'])) && (!isset($_GET ['last']))){
	$message = "Please provide details <a href=\"numbers.html\">Here</a>";
	echo $message;
	exit ();
	}
	else
	{
	$first = $_GET['first'];
	$last = $_GET['last'];
	}
	  
	if(($first=="Ken") && ($last=="Wake")){
	$message="Welcome Ken";
	}
	else
	{
	$message = "Welcome " . $first . " " . $last ;
	}
	  
	  ?>