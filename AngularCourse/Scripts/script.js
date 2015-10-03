/**
 * Created by dalmi on 10/3/2015.
 */
var work = function(){

    console.log("Working hard!");

};

var doWork = function(f){

    console.log("Starting");

    try{
        f();
    }
    catch(ex){
        console.log(ex);
    }

    console.log("Ending");
};

doWork(work);