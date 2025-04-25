function myFunction1(x, y, z) {
    return x + y + z;
}
const args1 = [0, 1, 2];
myFunction1(...args1);

function myFunction2(v, w, x, y, z) {
    return v + w + x + y + z;
}
const args2 = [0, 1];
myFunction2(-1, ...args2, 2, ...[3]);

const dateFields = [1970, 0, 1];
const d = new Date(...dateFields); // 1 Jan 1970
