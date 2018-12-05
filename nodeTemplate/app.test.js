import sum from "./app.js";

describe("Test function", () => {
    describe("When called", () => {
        it("Should be true", () => {
            
            //Arrange
            const a = 2;
            const b = 2;
            const expected = 4;
            
            //Act
            const actual = sum(a, b);

            //Assert
            expect(actual).toEqual(expected);
        });
    });
});
