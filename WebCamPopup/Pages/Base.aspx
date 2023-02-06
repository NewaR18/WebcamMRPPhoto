<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Base.aspx.cs" Inherits="WebCamPopup.Pages.Base" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.3/umd/popper.min.js" integrity="sha384-vFJXuSJphROIrBnz7yo7oB41mKfc8JzQZiCq4NCceLEaO4IHwicKwpJf9c9IpFgh" crossorigin="anonymous"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/js/bootstrap.min.js" integrity="sha384-alpBpkh1PFOepccYVYDB4do5UnbKysX5WZXm3XxPqe5iKTfUKjNkCk9SaVuEZflJ" crossorigin="anonymous"></script>
    <link href="../Scripts/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script src="../Scripts/WebCam.js"></script>
    <script src="../JS/base.js"></script>
    <link href="../CSS/base.css" rel="stylesheet" />
</head>
<body>
    <div class="mt-5 pt-5">
        <div class="d-flex justify-content-center mt-5 pt-5">
        <button type="button" id="cam" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal">
  Take Photo
</button>
</div>
<div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog modal-dialog-centered" role="document">
    <div class="modal-content">
      
      <div class="modal-body">
          <%--<div class="open1">
                <input type="button" id="cam" value="Open Camera" />
              <br />
          </div>--%>
    <div class="tablemain">
        <div>
            <div class="formimage2"><div id="webcam"></div></div>
            <div class="formimage"><img id = "imgCapture" class="myownimg4"/></div>
            </div>
    </div>
    <input type="button" id="btnCapture" value="Capture" />
          <input type="button" id="btnRetake" value="Retake"/>
          <input type="button" id="btnUpload" value="Upload" data-dismiss="modal"/>
      </div>
    </div>
  </div>
</div>
    </div>
    <div class="makeitcenter" style="display:flex; justify-content:center; margin-top:50px;">
    <div class="open1">
        <img border="0" id="displayimage" class="makeitMRP" alt="photo" style="display: none;" />
    </div>
    </div>
</body>
</html>
