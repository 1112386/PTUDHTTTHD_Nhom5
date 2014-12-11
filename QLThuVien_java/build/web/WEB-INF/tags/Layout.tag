
<%@tag description="put the tag description here" pageEncoding="UTF-8"%>

<%-- The list of normal or fragment attributes can be specified here: --%>
<%@attribute name="title"%>
<%@attribute name="content" fragment="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>${title}</title>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
<link href="${pageContext.request.contextPath}/template/css/style.css" rel="stylesheet" type="text/css" />


</head>
<body>
<div class="main">
  <div class="search">
      
    <div class="clr"></div>
  </div>
  <div class="clr"></div>
  <div class="header">
    <div class="logo">
      <h1><a href="index.html"><span>Libary</span><small>ĐH KHTN</small></a></h1>
    </div>
    <div class="menu_nav">
      <ul>
        <li class="active"><a href="/home/">Home</a></li>
        <li><a href="/home/support">Support</a></li>
        <li><a href="/SendMailer/Index">About Us</a></li>
        <li><a href="/home/blog">Blog</a></li>
        <li><a href="/home/contact">Contact Us</a></li>
      </ul>
      <div class="clr"></div>
    </div>
    <div class="clr"></div>
  </div>
  <div class="hbg"><img src="${pageContext.request.contextPath}/template/images/1413690263.jpg" width="970" height="250" alt="" /></div>
  <div class="content">
	<div class="sidebar">
      <div class="gadget">
        <h2><span>Sidebar</span> Menu</h2>
        <div class="clr"></div>
        <ul class="sb_menu">
          <li class="active"><a href="#">Home</a></li>
          <li><a href="#">TemplateInfo</a></li>
          <li><a href="#">Style Demo</a></li>
          <li><a href="#">Blog</a></li>
          <li><a href="#">Archives</a></li>
        </ul>
      </div>
    </div>
    <div class="mainbar">
        
        <jsp:invoke fragment="content"/>
        
    </div> 
    <div class="clr"></div>
  </div>
  <div class="clr"></div>
  <div class="footer">
    <p class="lf">&copy; Copyright <a href="#">Nhóm 5</a>.</p>
    <p class="rf">HTTT Hiện đại</p>
    <div class="clr"></div>
  </div>
</div>
<div align=center>This template  downloaded form <a href='http://all-free-download.com/free-website-templates/'>free website templates</a></div></body>
</html>