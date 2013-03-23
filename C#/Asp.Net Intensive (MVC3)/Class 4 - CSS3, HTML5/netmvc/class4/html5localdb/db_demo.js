$(function(){ initDatabase();
 	// Button and link actions
	$('#clear').click(function(){ dropTables(); });
 	$('#update').click(function(){ updateSetting(); });
});

/** Open Database Connection / Database Authentication **/
function initDatabase() {
    try {
        if (!window.openDatabase) {
            alert('Local Databases are not supported by your browser. Please use a Webkit browser for this demo');
        } 
        else {
            var shortName = 'DEMODB';
            var version = '1.0';
            var displayName = 'DEMODB Test';
            var maxSize = 100000; // in bytes
            DEMODB = openDatabase(shortName, version, displayName, maxSize);
            createTables();
            selectAll();
        }
    } catch (e) {
        if (e == 2) {// Version mismatch.
            console.log("Invalid database version.");
        } else {
            console.log("Unknown error " + e + ".");
        }
        return;
    }
}

/* CREATE TABLE */
function createTables() {
    DEMODB.transaction(
        function (transaction) {
            transaction.executeSql('CREATE TABLE IF NOT EXISTS page_settings(id INTEGER NOT NULL PRIMARY KEY, fname TEXT NOT NULL,bgcolor TEXT NOT NULL, font TEXT, fontSize TEXT);', [], nullDataHandler, errorHandler);
        }
    );
    prePopulate();
}

/* INSERT INTO TABLE */
function prePopulate() {
    DEMODB.transaction(
	    function (transaction) {//Starter data when page is initialized
	        var data = ['1', 'none', '#00FFFF', 'Arial', 'small'];
	        transaction.executeSql("INSERT INTO page_settings(id, fname, bgcolor, font, fontSize) VALUES (?, ?, ?, ?, ?)", [data[0], data[1], data[2], data[3], data[4]]);
	    }
	);
}

/* Obove all happens when the page loads. */

/* UPDATE TABLE */
function updateSetting() {
    DEMODB.transaction(
	    function (transaction) {
	        if ($('#fname').val() != '') {
	            var fname = $('#fname').val();
	        } else {
	            var fname = 'none';
	        }
	        var bg = $('#bg_color').val();
	        var font = $('#font_selection').val();
	        var fontSize = $('#fontSize_selection').val();
	        transaction.executeSql("UPDATE page_settings SET fname=?, bgcolor=?, font=? WHERE id = 1", [fname, bg, font, fontSize]);
	    }
	);
    selectAll();
}

/*Display*/
function selectAll(){ 
	DEMODB.transaction(
	    function (transaction) {
	        transaction.executeSql("SELECT * FROM page_settings;", [], dataSelectHandler, errorHandler);
	    }
	);	
}

function dataSelectHandler(transaction, results){
	// Handle the results
    for (var i=0; i<results.rows.length; i++) {
    	var row = results.rows.item(i);
        var newFeature = new Object();
    	
    	newFeature.fname   = row['fname'];
        newFeature.bgcolor = row['bgcolor'];
        newFeature.font = row['font'];
        newFeature.fontSize = row['fontSize']
        
        $('body').css('background-color',newFeature.bgcolor);
        $('body').css('font-family', newFeature.font);
        $('body').css('font-size', newFeature.fontSize);
        
        if(newFeature.fname != 'none') {
       		$('#greeting').html('Hello '+ newFeature.fname+'! Welcome Back!');
       		$('#fname').val(newFeature.fname);
        } 
        
       $('select#font_selection').find('option[value='+newFeature.font+']').attr('selected','selected');
       $('select#bg_color').find('option[value='+newFeature.bgcolor+']').attr('selected','selected'); 
    }
}

/* Save 'default' data into DB table */
function saveAll(){
		prePopulate(1);
}


function errorHandler(transaction, error){
 	if (error.code==1){
 		// DB Table already exists
 	} else {
    	// Error is a human-readable string.
	    console.log('Oops.  Error was '+error.message+' (Code '+error.code+')');
 	}
    return false;
}

function nullDataHandler(){
	console.log("SQL Query Succeeded");
}

/* SELECT DATA */
function selectAll(){ 
	DEMODB.transaction(
	    function (transaction) {
	        transaction.executeSql("SELECT * FROM page_settings;", [], dataSelectHandler, errorHandler);
	    }
	);	
}

/* DELETE DB TABLE */
function dropTables(){
	DEMODB.transaction(
	    function (transaction) {
	    	transaction.executeSql("DROP TABLE page_settings;", [], nullDataHandler, errorHandler);
	    }
	);
	console.log("Table 'page_settings' has been dropped.");
	location.reload();
}