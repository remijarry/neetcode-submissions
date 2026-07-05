class Solution {
  /**
   * @param {string[]} strs
   * @returns {string}
   */
  encode(strs) {
    let encoded = "";
    for (let str of strs) {
      encoded += str.length + "-" + str;
    }

    return encoded;
  }

  /**
   * @param {string} str
   * @returns {string[]}
   */
  decode(str) {
    let wordLength = "";
    let result = [];
    let i = 0;
    while (i < str.length) {
      if (str[i] === "-") {
        let l = parseInt(wordLength);
        i++;
        let j = i + l;
        let word = "";
        while (i < j) {
          word += str[i++];
        }
        result.push(word);
        i = j;
        wordLength = "";
      } else {
        wordLength += str[i];
        i++;
      }
    }

    return result;
  }
}