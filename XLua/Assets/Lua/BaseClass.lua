
function BaseClass(super)
    if not super then
        local o = {}
        setmetatable(o, self)
        self.__index = self
        return o
    else
        local o = {}
        setmetatable(o, super)
        o.__index = super
        return o
    end
end