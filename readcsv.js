const createCsvWriter =  require('csv-writer').createObjectCsvWriter;
const csvWriter = createCsvWriter({
    path:'sample.csv',
    header:[
        {id:'name', title:'name'},
        {id:'age', title:'age'},
        {id:'email', title:'email'}
    ]
    
});
const info = [
 {name:'aksha', age:25,email:'aksha@gmail.com'},
 {name:'shree', age:34,email:'shree@gmail.com'},
 {name:'sneha', age:20,email:'sneha@gmail.com'},
];
csvWriter.writeRecords(info)
.then(()=>{
console.log('csv file writtensuccessfully');
});