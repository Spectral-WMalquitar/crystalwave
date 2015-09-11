<!DOCTYPE html>
<html lang="en">
<head>
  	<title>Contacts</title>
  	<meta charset="utf-8">
    <meta name="description" content="Your description">
    <meta name="keywords" content="Your keywords">
    <meta name="author" content="Your name">
	<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <link rel="stylesheet" href="css/style.css">
	<link rel="stylesheet" href="css/zerogrid.css">
	<link rel="stylesheet" href="css/responsive.css">
	<script src="js/css3-mediaqueries.js"></script>
    <script src="js/jquery-1.7.1.min.js"></script>
    <script src="js/superfish.js"></script>
    <script src="js/jquery.easing.1.3.js"></script>
    <script src="js/tms-0.4.1.js"></script>
    <script src="js/slider.js"></script>
<!--[if lt IE 8]>
   <div style=' clear: both; text-align:center; position: relative;'>
     <a href="http://windows.microsoft.com/en-US/internet-explorer/products/ie/home?ocid=ie6_countdown_bannercode">
       <img src="http://storage.ie6countdown.com/assets/100/images/banners/warning_bar_0000_us.jpg" border="0" height="42" width="820" alt="You are using an outdated browser. For a faster, safer browsing experience, upgrade for free today." />
    </a>
  </div>
<![endif]-->
<!--[if lt IE 9]>
	<script src="js/html5.js"></script>
	<link rel="stylesheet" href="css/ie.css"> 
<![endif]-->
</head>
<body>
<div class="main-bg">
    <!-- Header -->
    <header>
		<div class="nav-responsive"><div>MENU</div>
			<select onchange="location=this.value">
				<option></option>
				<option value="index.php">Home</option>
				<option value="products.php">Rates</option>
				<option value="reservation.php">Reservation</option>
				<option value="aboutus.php">About Us</option>
				<option value="login.php">Log In</option>
			</select>
		</div>
    	<div class="inner">
            <h1 class="logo"><a href="index.php">Crystal Wave - Hotel and Resort</a></h1>
            <nav>
                <ul class="sf-menu">
                    <li><a href="index.php">Home</a></li>
                    <li><a href="products.php">Rates</a></li>
                    <li class="current"><a href="reservation.php">Reservation</a></li>
                    <li><a href="aboutus.php">About Us</a></li>
					<li><a href="login.php">Log In</a></li>
                </ul>
            </nav>
            <div class="clear"></div>
        </div>
		
    </header>
    <!-- Content -->
    <section id="content"><div class="ic">More Website Templates @ TemplateMonster.com | Zerotheme.com</div>
        <div class="zerogrid">
            	<div class="row content-bg">

                    	<article class="col-1-3"><br>
						<h2 class="heading-1">Log-In:</h2>
							<p class="hr-border-1">
                            	
									<div class="wrap-col">
										<form id="index-form" method="post">
										  <fieldset>
											<label class="name">
												<span>Username:</span><br>
												<input type="text"><br><br>
											</label>
											
											<label class="email">
												<span>Password:</span><br>
												<input type="email">
											</label>
											
											<div class="btns">
												<br>
												<a class="button" onClick="document.getElementById('contact-form').reset()">Clear</a> &nbsp;
												<a class="button" onClick="document.getElementById('contact-form').submit()">Log-In</a> 
											</div>
										  </fieldset>
										</form>
									</div>
								  
                                </p>
                        </article>
                        <article class="col-2-3">
							<div class="wrap-col">
	                        	<h2>Terms and Conditions:</h2>
	                            <strong class="str-2">
									<br>1. &nbsp; &nbsp; Check-in time is 1:00 PM and the Check-out is 12:00 NN of the following day.<br>
									<br>2. &nbsp; &nbsp; If the guest comes earlier than 1:00 PM, he/she may stay in the cottage until the allowed time to <br> &nbsp; &nbsp; &nbsp; &nbsp; check-in. <br>
									<br>3. &nbsp; &nbsp; Any extension in the lodging will be automatically charged with the same rate of the whole <br> &nbsp; &nbsp; &nbsp; &nbsp; accommodation.<br>
									<br>4. &nbsp; &nbsp; The management will not be responsible for the loss or damage of any personal belongings.<br>
									<br>5. &nbsp; &nbsp; If any room's item is lost, the guest should pay the equivalent amount. <br>
									<br>6. &nbsp; &nbsp; Room key must be surrendered to the cashier before check-out time. In case of lost of key, there <br> &nbsp; &nbsp; &nbsp; &nbsp; will be a charge of Php 300 per key.
								</strong><br><br><br> &nbsp; &nbsp; &nbsp; &nbsp;
								<strong class="str-3"><a href="#">I have read and understood the above terms and conditions and hereby follow them. I understand that the information contained in this document can be used by Crystal Waves Hotel and Resort Management for future references.</a></strong>
							</div>
                        </article>
            </div>
        </div>
    </section>
    <!-- Footer -->
	<footer>
    	<div class="zerogrid">
        	<div class="row footer-bg">
        			<div class="hr-border-2"></div>
                    <div class="wrapper">
                        <div class="col-1-3">
							<div class="wrap-col">
	                        	<div class="copyright">
	                            	&copy; 2015 <strong class="footer-logo">CrystalWaves</strong>
	                            </div>
							</div>
                        </div>
                    </div>
        	</div>
        </div>
    </footer>
</div>
</body>
</html>