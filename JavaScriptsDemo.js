// Changing the style of an element 
function elementStyleChange(){
	var elem = document.getElementById("demo");
	var x = elem.style.cssText = "color:green; font-size:35px;";
}

//To get parent rule property
function parentRulePropertyChange(){
	var x = document.styleSheets[0].rule[0].style;
	var ruleObj = x.parentRule;
	document.getElementById("demo").innerHTML = ruleObj.cssText;
}

//To change the source of src of an images
function changeSRC(){
	var src = document.getElementById('myImage').src;
    if(src=="https://www.w3schools.com/jS/pic_bulboff.gif"){
    	document.getElementById('myImage').src = "https://www.w3schools.com/jS/pic_bulbon.gif";
       }
      else{
      document.getElementById('myImage').src = "https://www.w3schools.com/jS/pic_bulboff.gif";
      }
}

//To change inner HTML of an element
function changeElementText(){
	document.getElementById("demo").innerHTML = "HelloWorld";
}

//To change CSS style

function changeCSSStyle(){
	var elem = document.getElementById("demo");
	var dis = elem.style.display;
	//To Hide or display the element 
	if(dis == "none")
		elem.style.display = "block"; //for displaying 
	else
		elem.style.display = "none"; // for hiding 
	//for changing the font size
	elem.style.fontSize ="10px";
}

function changeJavaScripyOutput(){
	var a = parseInt(document.getElementById("demo").innerHTML);  // parseInt is used to convert string to integer. 
	var b = parseInt(document.getElementById("demo2").innerHTML);
	window.alert("document.write() will clear whole web page!!!")
	document.writeln(a+b); //calling it after page is loaded will remove every thing.
	console.log("try it once");//select console in debug menu (F12 for chrome) to see the output.
}
 //
function changeJavaScriptStatement(){
	var x,y,z;
	x = 5;
	y = 6;
	z = x + y;
	document.getElementById("demo").innerHTML = "Value of Z is: - "+z+".";
}


