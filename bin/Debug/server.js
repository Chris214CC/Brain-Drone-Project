/*Reference: http://www.hacksparrow.com/tcp-socket-programming-in-node-js.html
*/

var net = require('net');
var arDrone = require('ar-drone');
var client = arDrone.createClient();
var http    = require('http');

var HOST = '127.0.0.1';
var PORT = 6969;
console.log('Connecting png stream ...');
var pngStream = arDrone.createClient().getPngStream();// Getting pngs from the drone. 

var lastPng;
pngStream
  .on('error', console.log)
  .on('data', function(pngBuffer) {
    lastPng = pngBuffer;
  });

var server = http.createServer(function(req, res) {// Creating the http server.
  if (!lastPng) {
    res.writeHead(503);
    res.end('Did not receive any png data yet.');
    return;
  }

  res.writeHead(200, {'Content-Type': 'image/png'});// Writing to a browser
  res.end(lastPng);
});

server.listen(8080, function() {
  console.log('Serving latest png on port 8080 ...');
});
// Create a server instance, and chain the listen function to it
// The function passed to net.createServer() becomes the event handler for the 'connection' event
// The sock object the callback function receives UNIQUE for each connection
net.createServer(function(sock) {
    
    // We have a connection - a socket object is assigned to the connection automatically
    console.log('CONNECTED: ' + sock.remoteAddress +':'+ sock.remotePort);
	
    try {
    // Add a 'data' event handler to this instance of socket
    sock.on('data', function(data) {
        
        console.log('DATA ' + sock.remoteAddress + ': ' + data);
        // Write the data back to the socket, the client will receive it as data from the server
       // sock.write('You said "' + data + '"');
	   client.on('navdata',function(navdata){
				client.after(1000, function() {
					console.log('Battery ' + navdata.demo.batteryPercentage);
					sock.write(navdata.demo.batteryPercentage.toString()); 
					//sock.write('Testing');
				}); 
			});
			
/* 
*	Commands being sent to the drone. 
*
*/
		if(data == "Takeoff")
		{
			//sock.write('Testing -T');
			console.log('Takeoff Command')
			client.takeoff();
			
			client.after(4000, function() {
			this.stop();
			}); 
			
		}
		
		if(data == "Land")
		{
			//sock.write('Testing -L');
			console.log('Landing Command');
			client.stop();	//stop moving before landing
			client.land();
		}
		if(data == "Up")
		{
			console.log('Up Command');
			client.up(0.1);
		}
		if(data == "Down")
		{
			console.log('Down Command');
			client.down(0.1);
		}
		if(data == "Forward")
		{
			console.log('Forward Command');
			client.front(0.1);
		}
		if(data == "Backward")
		{
			console.log('Backward Command');
			client.back(0.1);
		}		
		if(data == "TurnLeft")
		{
			console.log('Turn Left Command');
			client.counterClockwise(0.1);
		}
		if(data == "TurnRight")
		{
			console.log('Turn Right Command');
			client.clockwise(0.1);
		}
		if(data == "Left")
		{
			console.log('Strafe Left Command');
			client.left(0.1);
		}
		if(data == "Right")
		{
			console.log('Strafe Right Command');
			client.right(0.1);
		}
		
        
    });
    } catch (error) { //Error handling
	}
    // Add a 'close' event handler to this instance of socket
    sock.on('close', function(data) {
        console.log('CLOSED: ' + sock.remoteAddress +' '+ sock.remotePort);
    });
    
}).listen(PORT, HOST);

console.log('Server listening on ' + HOST +':'+ PORT);
