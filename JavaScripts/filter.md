# return array items "gender" = "Male"  
var result = data.class.students.filter(function( obj ) {
  return obj.gender == "Male";
});


# Data
var data = {
  	"class" : {
        "students" : [
        	{
            "id" : "S01",
            "name" : "Ly Nhan Tong",
            "age" : 20,
            "phone" : 0969692268,
            "gender" : "Male",
            "address" : "Ha Noi"
          },
          {
            "id" : "S02",
            "name" : "Le Anh Phuong",
            "age" : 19,
            "phone" : 0969692268,
            "gender" : "Female",
            "address" : "Ha Nam"
          },
          {
            "id" : "S03",
            "name" : "Le Hoan",
            "age" : 20,
            "phone" : 0969692268,
            "gender" : "Male",
            "address" : "Ha Tay"
       		}
       ]
		}
}