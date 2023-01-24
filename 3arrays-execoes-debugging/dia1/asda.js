function xablau(numers, k){
    let sum = 0;
    for(let i = 0; i < numers.length + 1; i++) {
        if(numers[i] <= k){
            sum+=1;
            continue
        }
        for(let j = 0; j < numers.length; j++ ) {
            // console.log("asdad", sum);
            if(numers[j] < k){
                sum += 1
            }
        }
    }
    return sum;
}
console.log(xablau([1,2,3], 7), "espero 6");
console.log(xablau([1,2,3], 7), "espero 6");
console.log(xablau([1,2,3], 7), "espero 6");
