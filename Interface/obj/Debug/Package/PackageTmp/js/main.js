$(document).ready(function () {
    $('.lb-rotate').live('click', function () {
        
        $cont = $('.pp_pic_holder');
        $image = $('#fullResImage');

        if ($($cont).attr('angle') == null) {
            $($cont).attr('angle', 0);
        }
        var value = Number($($cont).attr('angle'));
        value += 90;

        $($cont).rotate({ animateTo: value });
        $($cont).attr('angle', value);

        return false;
    });
});