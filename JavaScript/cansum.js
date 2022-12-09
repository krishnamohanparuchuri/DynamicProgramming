const cansum = (targetsum,numbers) =>{

    if(targetsum = 0) return true;
    if(targetsum < 0) return false;
    for(let num of numbers){
        const remainder = targetsum-num;

        if(cansum(remainder,numbers) === true){
            return true;
        };
    }
    return false;

}

console.log(cansum(7,[2,3]));
// console.log(cansum(7,[5,3,4,7]));
// console.log(cansum(7,[2,4]));
// console.log(cansum(8,[1,3,5]));

